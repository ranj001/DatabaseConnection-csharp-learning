# Database Connection and Command

## DbConnection and DbCommand - Learning Exercise

A minimal .NET 8 console project intended as a hands‑on learning exercise in C#.  
Demonstrates designing an abstract database connection base class (DbConnection), concrete providers (SqlConnection, OracelConnection), and a simple DbCommand that opens, executes, and closes connections.

### Overview
This repository contains a minimal .NET 8 console app that models a database connection abstraction:
- Abstract base class with required Open/Close implementations
- Concrete Sql and Oracle connection stubs
- DbCommand wrapper that validates input and uses a DbConnection
- Small, self-contained console demo

### Learning objectives
- Implement and use abstract classes and properties in C#
- Provide concrete overrides for abstract members
- Run and debug a .NET console app in Visual Studio or dotnet CLI
