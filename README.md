# Modular Monolith in C#

Monoliths are not inherently bad, but they can be better if the proper care is taken when building one. This repository
is a sample implementation of a modular monolith in C# based on several sources (acknowledgements at the bottom).

## Table of Contents

- [Introduction](#introduction)
- [Monolith versus a Modular Monolith](#monolith-versus-a-modular-monolith)
- [Modular Monolith versus Microservices](#modular-monolith-versus-microservices)
- [Technologies used](#technologies-used)
- [Acknowledgements](#acknowledgements)

## Introduction

Monoliths are a project structure where all the code for a solution resides in a single solution and deployed as a 
single unit. This is in contrast to a Microservices architecture where the code is broken up into multiple services that
are deployed independently and communicate over a network.

By clearly separating your code into independent modules that are assembled by the host application, you can start with 
a single code base that can can evolve rapidly without developers stepping on each others code. If you later discover a
particular module needs to be scaled independently, you can easily extract it into a separate service without worrying
about tight coupling.

## Monolith versus a Modular Monolith

| Aspect              | Monolith                                                   | Modular Monolith                                                                                       |
|---------------------|------------------------------------------------------------|--------------------------------------------------------------------------------------------------------|
| **Architecture**    | Usually a single or n-tier architecture                    | Consists of a single `host` that loads one or more loosely coupled modules                             |
| **Codebase**        | Single codebase that contains all operations               | Independent projects that contain all the logic for the module                                         |
| **Maintainability** | Can become difficult to maintain as the codebase grows     | Easier to maintain as each module is self-contained and can be developed and unit tested independently |
| **Ease of Change**  | May require extensive changes if not carefully constructed | Modules can be added or removed with minimal impact                                                    |

## Modular Monolith versus Microservices

| Aspect          | Modular Monolith                                                                  | Microservices                                                                         |
|-----------------|-----------------------------------------------------------------------------------|---------------------------------------------------------------------------------------|
| **Simplicity**  | Tends to be easier to develop and deploy                                          | Typically used for complex projects that require a lot of scalability and flexibility |
| **Performance** | Can be faster in certain situations due to in-process communication               | Could be slower due to the increased use of network communication between services    |
| **Deployment**  | Deployed as a single unit                                                         | Deployment of multiple services needs to be coordinated and orchestrated              |
| **Cost**        | Initial costs are smaller due to a single unit, but scaling can be more expensive | Usually higher due to increased infrastructure                                        |

## Technologies Used

- [Scalar](https://github.com/scalar/scalar): Better OpenAPI UI Client
- [MediatR](https://github.com/jbogard/MediatR): Simple and performant implementation of the Mediator Pattern in .NET
- [ArchUnit](https://archunitnet.readthedocs.io/en/latest/): Unit testing library that allows you to validate that your code is following stated architecture rules.

## Acknowledgements
- **Code Maze**: [Modular Monolith Architecture In .NET](https://code-maze.com/dotnet-modular-monolith/)
- **Thinktecture**: [Modular Monoliths With ASP.NET Core – Pragmatic Architecture](https://www.thinktecture.com/en/asp-net-core/modular-monolith/)
- **Mukesh Murugan**: [Modular Architecture in ASP.NET Core - Building Better Monoliths](https://codewithmukesh.com/blog/modular-architecture-in-aspnet-core/) 
