# ModularMonolith

Monoliths are not inherently bad, but they can be better if the proper care is taken when building one. This repository
is a sample implementation of a modular monolith in C# based on several sources (acknowledgements at the bottom).

## Table of Contents

- [Introduction](#introduction)
- [Advantages of a Monolith](#advantages-of-a-monolith)
- [Disadvantages of a Monolith](#disadvantages-of-a-monolith)
- [Advantages of Microservices](#advantages-of-microservices)
- [Disadvantages of Microservices](#disadvantages-of-microservices)
- [Acknowledgements](#acknowledgements)

## Introduction

Monoliths are a project structure where all the code for a solution resides in a single solution and deployed as a 
single unit. This is in contrast to a Microservices architecture where the code is broken up into multiple services that
are deployed independently and communicate over a network.

By clearly separating your code into independent modules that are assembled by the host application, you can start with 
a single code base that can can evolve rapidly without developers stepping on each others code. If you later discover a
particular module needs to be scaled independently, you can easily extract it into a separate service without worrying
about tight coupling.

## Advantages of a Monolith

- **Simplicity**: Monoliths are simpler to build and deploy than microservices. This can be super helpful when first 
  starting a project because you most likely don't know what you are going to need in the beginning.
- **Performance**: Monoliths can be faster than microservices because they don't have to communicate over a network.
- **Development Speed**: Monoliths are faster to develop than microservices because you don't have to worry about the 
  complexities of distributed systems.
- **Easier to Debug**: Monoliths are easier to debug than microservices because you can step through the code in a 
  single process.
- **Easier to Deploy**: Monoliths are easier to deploy than microservices because you only have to deploy a single 
  unit.
- **Easier to Monitor**: Monoliths are easier to monitor than microservices because you can monitor the entire system 
  in a single process.
- **Easier to Maintain**: Monoliths are easier to maintain than microservices because you only have to maintain a 
  single codebase.
- **Easier to Secure**: Monoliths are easier to secure than microservices because you only have to secure a single 
  codebase.
- **Easier to Refactor**: Monoliths are easier to refactor than microservices because you only have to refactor a 
  single codebase.
- **Easier to Scale**: Monoliths are easier to scale than microservices because you only have to scale a single 
  unit.

## Disadvantages of a Monolith

- **Complexity**: Monoliths can become complex as they grow in size and complexity.
- **Performance**: Monoliths can be slower than microservices because they have to do more work in a single process which
  can limit the number of requests they can handle simultaneously.
- **Development Speed**: Monoliths can be slower to develop than microservices as the code base grows, especially with a 
  larger number of developers, due to merge conflicts if the code is not properly structured.
- **Cost to Scale**: Monoliths can be more expensive to scale than microservices because you have to scale the entire 
  system together.

## Advantages of Microservices

- **Scalability**: Microservices can be scaled independently of each other which can be more cost-effective than scaling 
  an entire monolith.
- **Flexibility**: Microservices can be developed and deployed independently of each other which can be more flexible 
  than a monolith.
- **Resilience**: Microservices can be more resilient than a monolith because if one service fails, the other services 
  can continue to function.
- **Technology Agnostic**: Microservices can be developed in different technologies which can be more flexible than a 
  monolith.
- **Easier to Understand**: Microservices can be easier to understand than a monolith because each service is smaller 
  and more focused.

## Disadvantages of Microservices

- **Complexity**: Microservices can be more complex than a monolith because you have to manage multiple services 
  instead of a single codebase.
- **Performance**: Microservices can be slower than a monolith because they have to communicate over a network which 
  can introduce latency.
- **Development Speed**: Microservices can be slower to develop than a monolith because you have to manage multiple 
  services instead of a single codebase.
- **Cost to Scale**: Microservices can be more expensive to scale than a monolith because you have to scale each 
  service independently.
- **Testing**: Microservices can be harder to test than a monolith because you have to test each service 
  independently as well as the integrations between all the services.

## Acknowledgements
- **Code Maze**: [Modular Monolith Architecture In .NET](https://code-maze.com/dotnet-modular-monolith/)
- **Thinktecture**: [Modular Monoliths With ASP.NET Core – Pragmatic Architecture](https://www.thinktecture.com/en/asp-net-core/modular-monolith/)
- **Mukesh Murugan**: [Modular Architecture in ASP.NET Core - Building Better Monoliths](https://codewithmukesh.com/blog/modular-architecture-in-aspnet-core/) 
