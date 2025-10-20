# DatabaseConnection

## DbConnection Learning Exercise

A small, self-contained project designed as a project learning exercise to demonstrate designing an abstract database connection base class and concrete implementations (SQL/Oracle). Focus areas: abstract properties, inheritance, implementing Open/Close, and enforcing a connection timeout.

### Overview
This repository contains a minimal .NET 8 console app that models a database connection abstraction:
- DbConnection (abstract base class)
- SqlConnection (concrete implementation)
- OracelConnection (placeholder for another provider)
- Program (example usage)

The goal is learning object-oriented design in C# and implementing a basic timeout pattern for opening connections.

### Learning objectives
- Implement and use abstract classes and properties in C#
- Provide concrete overrides for abstract members
- Enforce an operation timeout and use cancellation patterns
- Run and debug a .NET console app in Visual Studio or dotnet CLI
