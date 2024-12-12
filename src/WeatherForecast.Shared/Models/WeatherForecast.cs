namespace WeatherForecast.Shared.Models;

/// <summary>
/// Weather forecast data points.
/// </summary>
public class WeatherForecast
{
    /// <summary>
    /// Date of the weather reading.
    /// </summary>
    public DateOnly Date { get; set; }

    /// <summary>
    /// Temperature reading in Celsius.
    /// </summary>
    public int TemperatureC { get; set; }

    /// <summary>
    /// Temperature reading in Fahrenheit.
    /// </summary>
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    /// <summary>
    /// Summary of the weather conditions.
    /// </summary>
    public string? Summary { get; set; }
}
