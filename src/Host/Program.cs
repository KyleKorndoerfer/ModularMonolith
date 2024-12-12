using Host;
using Host.ModuleIntegration;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

// Add services to the container.
builder.Services.AddControllers().ConfigureApplicationPartManager(manager =>
{
    // clear auto-detected controllers
    manager.ApplicationParts.Clear();

    // Add feature provider to allow 'internal' controllers
    manager.FeatureProviders.Add(new InternalControllerFeatureProvider());
});

// Register a convention allowing us to prefix routes to modules.
builder.Services.AddTransient<IPostConfigureOptions<MvcOptions>, ModuleRoutingMvcOptionsPostConfigure>();

// Register Modules (i.e. - builder.Services.AddModule<Module1.Startup>("prefix"))
builder.Services.AddModule<WeatherForecast.Startup>("weather");

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference(options =>
    {
        options
            .WithDefaultHttpClient(ScalarTarget.CSharp, ScalarClient.HttpClient)
            .WithLayout(ScalarLayout.Classic)
            .WithTheme(ScalarTheme.Moon);
    });
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

#pragma warning disable ASP0014
app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
#pragma warning restore ASP0014

// Adds endpoints defined in modules
var modules = app.Services.GetRequiredService<IEnumerable<Module>>();
foreach (var module in modules)
{
    app.Map($"/{module.RoutePrefix}", appBuilder =>
    {
        appBuilder.UseRouting();
        module.Startup.Configure(appBuilder, app.Environment);
    });
}

app.MapControllers();

await app.RunAsync();
