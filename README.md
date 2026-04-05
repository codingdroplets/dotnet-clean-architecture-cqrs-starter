# dotnet-clean-architecture-cqrs-starter

> A structured starter template for Clean Architecture with CQRS and MediatR in ASP.NET Core 10 — explore the architecture, then get the full production implementation on Patreon.

[![Visit CodingDroplets](https://img.shields.io/badge/Website-codingdroplets.com-blue?style=for-the-badge&logo=google-chrome&logoColor=white)](https://codingdroplets.com/)
[![YouTube](https://img.shields.io/badge/YouTube-CodingDroplets-red?style=for-the-badge&logo=youtube&logoColor=white)](https://www.youtube.com/@CodingDroplets)
[![Patreon](https://img.shields.io/badge/Patreon-Support%20Us-orange?style=for-the-badge&logo=patreon&logoColor=white)](https://www.patreon.com/CodingDroplets)
[![Buy Me a Coffee](https://img.shields.io/badge/Buy%20Me%20a%20Coffee-Support%20Us-yellow?style=for-the-badge&logo=buy-me-a-coffee&logoColor=black)](https://buymeacoffee.com/codingdroplets)
[![GitHub](https://img.shields.io/badge/GitHub-codingdroplets-black?style=for-the-badge&logo=github&logoColor=white)](http://github.com/codingdroplets/)

## 🚀 Get the Complete Production Implementation

This repo is a **free starter template** — it gives you the full project structure and architecture to explore.

The **complete, production-ready version** with all business logic, pipeline behaviors, domain invariants, FluentValidation rules, global error handling, and **29 passing tests** is available exclusively on Patreon.

👉 **[Get the full Source Code on Patreon](https://www.patreon.com/posts/152905861)**

Prefer a one-time tip? [Buy us a coffee ☕](https://buymeacoffee.com/codingdroplets)

## 🎯 What You'll Learn

- How Clean Architecture layers are structured in a real .NET solution
- Why the dependency rule matters and how project references enforce it
- How CQRS separates commands from queries
- How MediatR pipeline behaviors work (logging, validation)
- Where each pattern fits in the folder structure

## 🗺️ Architecture Overview

```
┌─────────────────────────────────────────────────────────────────────┐
│                            API Layer                                │
│  ┌─────────────┐  ┌─────────────┐  ┌─────────────────────────────┐  │
│  │ Controllers │  │ Middleware  │  │ Program.cs (Wiring)         │  │
│  └─────────────┘  └─────────────┘  └─────────────────────────────┘  │
│         │                   │                     │                 │
│         └───────────────────┼─────────────────────┘                 │
│                             │                                       │
│  ┌──────────────────────────▼───────────────────────────────────┐   │
│  │              Application Layer                               │   │
│  │  ┌─────────────┐  ┌─────────────┐  ┌─────────────────────┐   │   │
│  │  │   Commands  │  │   Queries   │  │  Behaviors          │   │   │
│  │  │  (C Q R)    │  │  (C Q R)    │  │  (Pipeline)         │   │   │
│  │  └─────────────┘  └─────────────┘  └─────────────────────┘   │   │
│  │         │                   │                     │          │   │
│  │         └───────────────────┼─────────────────────┘          │   │
│  │                             │                                │   │
│  └─────────────────────────────┼────────────────────────────────┘   │
│                                │                                    │
│  ┌─────────────────────────────▼──────────────────────────────┐     │
│  │              Domain Layer                                  │     │
│  │  ┌─────────────┐  ┌─────────────┐  ┌─────────────────────┐ │     │
│  │  │  Entities   │  │  Value Obj  │  │  Interfaces/Repo    │ │     │
│  │  │  (Agg Roots)│  │  (Domain)   │  │  (Abstractions)     │ │     │
│  │  └─────────────┘  └─────────────┘  └─────────────────────┘ │     │
│  │         │                                                  │     │
│  └─────────┼──────────────────────────────────────────────────┘     │
│            │                                                        │
│  ┌─────────▼─────────────────────────────────────────────────────┐  │
│  │           Infrastructure Layer                                │  │
│  │  ┌─────────────┐  ┌─────────────┐  ┌─────────────────────┐    │  │
│  │  │ Repository  │  │   EF Core   │  │  Ext. Services      │    │  │
│  │  │  Impl       │  │ DbContext   │  │  (DB, Cache, etc)   │    │  │
│  │  └─────────────┘  └─────────────┘  └─────────────────────┘    │  │
│  └───────────────────────────────────────────────────────────────┘  │
└─────────────────────────────────────────────────────────────────────┘

Dependency Rule: Dependencies point INWARD toward Domain.
API → Application → Domain (Infrastructure → Domain as well)
```

## 📋 Summary

| Layer | Responsibility | Depends On | Full Implementation |
|-------|---------------|------------|---------------------|
| Domain | Business entities + rules | Nothing | ✅ Patreon |
| Application | Use cases (CQRS + MediatR) | Domain | ✅ Patreon |
| Infrastructure | EF Core + repositories | Domain + Application | ✅ Patreon |
| API | HTTP transport | Application + Infrastructure | ✅ Patreon |

## 📁 Project Structure

```
dotnet-clean-architecture-cqrs-starter/
├── dotnet-clean-architecture-cqrs-starter.sln
└── src/
    ├── CleanArchCqrs.Domain/
    │   ├── CleanArchCqrs.Domain.csproj
    │   ├── Common/
    │   │   └── BaseEntity.cs                    # Base class with Id
    │   ├── Entities/
    │   │   └── Product.cs                       # Product entity (stub properties only)
    │   ├── Exceptions/
    │   │   └── DomainException.cs              # Base domain exception
    │   └── Interfaces/
    │       └── IProductRepository.cs           # Repository contract (full method set)
    │
    ├── CleanArchCqrs.Application/
    │   ├── CleanArchCqrs.Application.csproj
    │   ├── Common/
    │   │   ├── Behaviors/
    │   │   │   ├── LoggingBehavior.cs          # Stub: passes through, no logging
    │   │   │   └── ValidationBehavior.cs       # Stub: passes through, no validation
    │   │   ├── Exceptions/
    │   │   │   └── ValidationException.cs      # Validation exception type
    │   │   └── Models/
    │   │       ├── ProductDto.cs               # DTO for API responses
    │   │       └── PagedResult.cs              # Pagination wrapper
    │   ├── DependencyInjection/
    │   │   └── ApplicationServiceExtensions.cs # Registers MediatR, behaviors, validators
    │   └── Products/
    │       ├── Commands/
    │       │   ├── CreateProduct/
    │       │   │   ├── CreateProductCommand.cs       # Returns Guid.Empty
    │       │   │   └── CreateProductCommandValidator.cs  # Empty validator
    │       │   ├── UpdateProduct/
    │       │   │   ├── UpdateProductCommand.cs      # Returns Unit.Value
    │       │   │   └── UpdateProductCommandValidator.cs  # Empty validator
    │       │   └── DeleteProduct/
    │       │       └── DeleteProductCommand.cs      # Returns Unit.Value
    │       ├── Queries/
    │       │   ├── GetProduct/
    │       │   │   └── GetProductQuery.cs          # Returns null/empty DTO
    │       │   └── GetProducts/
    │       │       └── GetProductsQuery.cs         # Returns empty PagedResult
    │       └── Validators/                          # Validator collection
    │           ├── CreateProductCommandValidator.cs
    │           └── UpdateProductCommandValidator.cs
    │
    ├── CleanArchCqrs.Infrastructure/
    │   ├── CleanArchCqrs.Infrastructure.csproj
    │   ├── DependencyInjection/
    │   │   └── InfrastructureServiceExtensions.cs  # Registers DbContext, repositories
    │   ├── Persistence/
    │   │   └── AppDbContext.cs                    # EF Core context (stub config)
    │   └── Repositories/
    │       └── ProductRepository.cs               # All methods throw NotImplementedException
    │
    └── CleanArchCqrs.API/
        ├── CleanArchCqrs.API.csproj
        ├── Controllers/
        │   └── ProductsController.cs              # Full CRUD endpoints with CQRS
        ├── Middleware/
        │   └── GlobalExceptionHandlerMiddleware.cs # Stub: just re-throws
        ├── Properties/
        │   └── launchSettings.json                # Swagger launch configured
        ├── Program.cs                              # Full service wiring + Swagger UI
        ├── appsettings.json
        └── appsettings.Development.json
```

## 🔓 Free Starter vs Full Patreon Version

This is the KEY section — see what you get in the complete production code:

| Feature | This Repo (Free) | Patreon Version |
|---------|-----------------|-----------------|
| Project structure (4 layers) | ✅ Complete | ✅ Complete |
| All .csproj with correct packages | ✅ Complete | ✅ Complete |
| Domain entity properties | ✅ Included | ✅ Included |
| Factory method + domain invariants | ❌ Stub | ✅ Full implementation |
| MediatR handler logic | ❌ Returns defaults | ✅ Full implementation |
| FluentValidation rules | ❌ Empty validators | ✅ Full implementation |
| Logging pipeline behavior | ❌ Pass-through stub | ✅ Structured logging + elapsed time |
| Validation pipeline behavior | ❌ Pass-through stub | ✅ Auto-validation with concurrent execution |
| Repository implementation | ❌ NotImplementedException | ✅ EF Core with AsNoTracking, search, pagination |
| Global exception handler | ❌ Re-throws | ✅ RFC 7807 Problem Details mapping |
| Unit tests (domain + handlers + validators) | ❌ Not included | ✅ 22 unit tests |
| Integration tests (WebApplicationFactory) | ❌ Not included | ✅ 7 integration tests |
| Pre-seeded data | ❌ No data | ✅ 3 products seeded on startup |
| Working API responses | ❌ Empty defaults | ✅ Full CRUD with search + pagination |

👉 **[Get the complete version on Patreon](https://www.patreon.com/posts/152905861)**

## 🛠️ Prerequisites

- **.NET 10 SDK** — [download from Microsoft](https://dotnet.microsoft.com/download/dotnet/10.0)
- **IDE** — Visual Studio 2022+, VS Code (with C# Dev Kit), or JetBrains Rider

## ⚡ Quick Start

```bash
# Clone the repository
git clone https://github.com/codingdroplets/dotnet-clean-architecture-cqrs-starter.git
cd dotnet-clean-architecture-cqrs-starter

# Restore NuGet packages
dotnet restore

# Build in Release
dotnet build -c Release

# Run the API (Swagger UI opens automatically)
dotnet run --project src/CleanArchCqrs.API/CleanArchCqrs.API.csproj
```

Then open:
- **Swagger UI:** http://localhost:5289 (HTTP) or https://localhost:7163 (HTTPS)
- **API base:** http://localhost:5289/api/products

> **Note:** This starter template returns empty/default responses because handlers are stubs. The full Patreon version returns real data with proper business logic.

## 🔧 How It Works

### 1. Domain Layer (CleanArchCqrs.Domain)
- Contains business entities, value objects, domain exceptions, and repository interfaces.
- **Zero dependencies** on other layers — it's pure business logic.
- `Product` entity: properties only in this stub; the full version includes factory methods, domain invariants, and encapsulated validation.

### 2. Application Layer (CleanArchCqrs.Application)
- Use cases implemented as CQRS commands and queries with MediatR.
- Pipeline behaviors for cross-cutting concerns: logging and validation.
- DTOs for data transfer and FluentValidation validators.
- Depends only on Domain (and MediatR/FluentValidation packages).

### 3. Infrastructure Layer (CleanArchCqrs.Infrastructure)
- Implements repository interfaces from Domain using EF Core.
- DbContext configuration and database-specific concerns.
- Depends on Domain (entities/interfaces) and Application (DTOs if needed).

### 4. API Layer (CleanArchCqrs.API)
- ASP.NET Core Web API with controllers that send commands/queries via IMediator.
- Global exception handling middleware (stub only here).
- Swagger/OpenAPI configuration for interactive API exploration.
- Wires up all layers in `Program.cs`.

### Dependency Injection Flow
```csharp
// In Program.cs (API)
services.AddApplicationServices();  // MediatR, behaviors, validators
services.AddInfrastructureServices(); // DbContext, repositories
```

Results in this container registration:
- `IRequest<T>` → `RequestHandler<T>` (MediatR)
- `IProductRepository` → `ProductRepository`
- `AppDbContext` → InMemory database (this stub)

## 📚 Further Reading

- **Article:** [Clean Architecture with CQRS + MediatR in ASP.NET Core 10](https://codingdroplets.com/clean-architecture-cqrs-mediatr-aspnet-core-2026)
- **Full Source Code:** [Get All Business Logic + 29 Tests](https://www.patreon.com/posts/152905861)

## 📄 License

MIT — see LICENSE file for details.

## 🔗 Connect with CodingDroplets

| Platform | Link |
|----------|------|
| 🌐 Website | https://codingdroplets.com/ |
| 📺 YouTube | https://www.youtube.com/@CodingDroplets |
| 🎁 Patreon | https://www.patreon.com/CodingDroplets |
| ☕ Buy Me a Coffee | https://buymeacoffee.com/codingdroplets |
| 💻 GitHub | http://github.com/codingdroplets/ |

> **Want more samples like this?** [Support us on Patreon](https://www.patreon.com/CodingDroplets) or [buy us a coffee ☕](https://buymeacoffee.com/codingdroplets) — every bit helps keep the content coming!
