# LibraryBlazorApp

A web application for managing a library system - including book loans, library cards, clients, and authors.
Built with Blazor using a layered Clean Architecture approach.

## UI Preview

### Library Cards
View and manage library cards assigned to clients.

![Library Cards](https://github.com/user-attachments/assets/9b09342b-4cf9-49cc-a633-a51a02d50a14)

### Books
Browse, add, and manage books in the system.

![Books](https://github.com/user-attachments/assets/821817ee-c4a1-4324-9bce-1c4a43b9d514)

## Project Status

In development

## Tech stack

- Blazor (Server-side), MudBlazor - UI
- C# / .NET - backend and application logic
- Entity Framework Core - ORM and database migrations
- SQL Server - relational database
- Clean Architecture - Domain / Application / Infrastructure / UI separation

## Architecture

The project follows a layered architecture based on Clean Architecture principles:
- `Domain` Contains core business entities and models
- `Application` Contains business logic, services, and use cases
- `Infrastructure` Handles database access (EF Core), persistence, and external services
- `UI` Blazor components and user interface layer

## Features

- Manage Clients, Library Cards, books and authors (CRUD)
- Track book loans and returns
- View loan history
- Validate input data using FluentValidation
- Maintain relationships between entities (books, clients, loans)
- Handle operation results using the Result Pattern (planned migration to middleware-based error handling)

## Completed

- Implementation of layered architecture (Domain / Application / Infrastructure / UI)
- Manage clients, library cards, books, and authors (CRUD operations)
- Entity relationships and navigation properties
- Book and author management (CRUD operations)
- Loan history tracking
- Entity Framework Core migrations and configuration
- Repository and service layer implementation
- Error Result Pattern
- Fluent Validation
- Borrow and return date tracking
- Unit tests for Loan and LibraryCard
- Basic user feedback via UI notifications (e.g. success/error messages)

## Planned

- Library card management
- Client registration with address details
- UI development with Blazor and MudBlazor
- Loan CRUD operations
- Logging integration (NLog)
- Error Handling Middleware
- User roles
- Authentication and authorization (ASP.NET Core Identity)
- Unit and integration tests (xUnit)
- Move connection string to appsettings.json

## Getting Started

Follow the steps below to run the application locally.

### Setup

1. Clone the repository:
   git clone https://github.com/SzymonKonopnicki/LibraryBlazorApp.git

2. Navigate to the project folder:
   cd LibraryBlazorApp

3. Update the connection string directly in the Infrastructure layer (currently hardcoded)

4. Apply database migrations:
   dotnet ef database update

5. Run the application:
   dotnet run
   
### Prerequisites

- .NET 8 SDK or later
- SQL Server

## License

This project is for educational purposes.

## Notes

- The connection string is currently hardcoded in the Infrastructure layer and will be moved to appsettings.json in a future update.
- This project is developed as a learning exercise focused on applying Clean Architecture principles in a real-world application.
