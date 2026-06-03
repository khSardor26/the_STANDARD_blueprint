# CleanArchitecture.Blueprint

A small .NET API blueprint for future clean architecture projects.

## Solution Structure

```text
src/
  CleanArchitecture.Blueprint.Api/
  CleanArchitecture.Blueprint.Api.Tests.Unit/
  CleanArchitecture.Blueprint.Api.Tests.Acceptance/
```

## Projects

- `CleanArchitecture.Blueprint.Api` contains the Web API and application architecture.
- `CleanArchitecture.Blueprint.Api.Tests.Unit` contains fast tests for isolated classes.
- `CleanArchitecture.Blueprint.Api.Tests.Acceptance` contains API-level tests that run through the HTTP pipeline.

## API Architecture

The API project keeps the first layer simple:

- `Controllers` expose HTTP endpoints and delegate work.
- `Brokers` wrap external concerns such as logging, storage, queues, email, or third-party APIs.
- `Data` contains database context setup.
- `Models` contains core data models.

As the project grows, add feature logic in small service classes before controllers become busy. Keep controllers thin, keep external dependencies behind brokers, and keep tests close to the behavior they protect.

## Getting Started

```bash
dotnet build CleanArchitecture.Blueprint.slnx
dotnet test CleanArchitecture.Blueprint.slnx
dotnet run --project src/CleanArchitecture.Blueprint.Api
```

Open `/health` to confirm the API is running.

## Clean Architecture Rules

1. Business logic should not depend on infrastructure details.
2. Controllers should coordinate HTTP requests, not contain business rules.
3. Brokers are the boundary for external systems.
4. Unit tests should cover rules and small services.
5. Acceptance tests should cover important API workflows.
6. Add only the abstractions that the current feature needs.
7. Service layer must be implemented following TDD
8. At least HAPPY-PATH tests recommended 
   
