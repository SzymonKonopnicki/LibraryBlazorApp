# LibraryBlazorApp

A web application for managing a library system - including book loans, library cards, clients, and authors.
Built with Blazor using a layered Clean Architecture approach.

## Project Status

In development

## Tech stack

- Blazor (Server-side), MudBlazor - UI
- C# / .NET - backend and application logic
- Entity Framework Core - ORM and database migrations
- SQL Server - relational database
- Clean Architecture - Domain / Application / Infrastructure / UI separation

## Features

- Book and author management (CRUD operations)
- Client registration with address details
- Library card management
- Loan history tracking
- Borrow and return date tracking

## Architecture

The project follows a layered architecture based on Clean Architecture principles:

- `Domain` Contains core business entities and models
- `Application` Contains business logic, services, and use cases
- `Infrastructure` Handles database access (EF Core), persistence, and external services
- `UI` Blazor components and user interface layer

## Completed

- Implementation of layered architecture (Domain / Application / Infrastructure / UI)
- Domain models: Book, Author, Client, Address, LibraryCard, Loan
- Entity relationships and navigation properties

## Planned

- Entity Framework Core migrations and configuration
- Repository and service layer implementation
- UI development with Blazor and MudBlazor
- Logging integration (NLog)
- Application setup and run instructions

## Getting Started

Instructions will be added soon.

## Notes

This project is being developed as a learning exercise to practice:
