# References Used In SuggestionApp

## Technologies & Frameworks

- [.NET 10](https://dotnet.microsoft.com/download/dotnet/10.0) – Main platform
- [Blazor Server](https://learn.microsoft.com/aspnet/core/blazor/) – Server-side interactive UI framework
- [MongoDB.Driver](https://www.mongodb.com/docs/drivers/csharp/current/) – Data access to MongoDB
- [Microsoft.Identity.Web](https://learn.microsoft.com/entra/msal/dotnet/microsoft-identity-web/) – Azure AD B2C sign-in, with
  Microsoft.Identity.Web.UI for the sign-in and sign-out pages
- [Microsoft.Extensions.Caching.Memory](https://learn.microsoft.com/dotnet/core/extensions/caching) – In-memory caching
  of data store results
- [Bootstrap](https://getbootstrap.com/) and [Open Iconic](https://github.com/iconic/open-iconic) – Styling and icons

## Workflows & Actions

- [GitHub Actions](https://github.com/features/actions) – CI for build, test, lint, CodeQL, review and releases

## Development Tools

- [Visual Studio](https://visualstudio.microsoft.com/) – IDE
- [JetBrains Rider](https://www.jetbrains.com/rider/) – IDE
- [Visual Studio Code](https://code.visualstudio.com/) – Lightweight editor, cross-platform

## Architecture & Patterns

- [Dependency Injection](https://learn.microsoft.com/aspnet/core/fundamentals/dependency-injection) – Built-in ASP.NET Core
  DI container, registered in `RegisterServices.cs`
- Repository-style data stores – `I*Data` interfaces with MongoDB implementations in `SuggestionAppLibrary/DataAccess`
