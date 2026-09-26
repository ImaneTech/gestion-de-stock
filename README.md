# Gestion de Stock

[![Build](https://github.com/ImaneTech/gestion-de-stock/actions/workflows/build.yml/badge.svg)](https://github.com/ImaneTech/gestion-de-stock/actions/workflows/build.yml)

A Windows desktop inventory management application for a small electronics business. It manages products and stock levels, clients and suppliers, sales and purchases, invoices and monthly financial reports. Team project (5 students).

## Demo

[![Demo video](https://img.youtube.com/vi/NxuR2FhwWms/maxresdefault.jpg)](https://www.youtube.com/watch?v=NxuR2FhwWms)

## Key features

- **Dashboard** with stock value, key counts and low-stock alerts
- **Product, client and supplier management** with search
- **Multi-product sales and purchases** with automatic stock updates
- **Sales and purchase invoices** with paid/unpaid tracking
- **Monthly reports** of revenue, expenses and profit
- **Role-based access** with admin and user accounts

## Security

- Passwords hashed with PBKDF2-SHA256 and a per-user salt, with transparent migration of legacy passwords at login
- Admin/user roles, and account lockout after repeated failed logins
- Parameterized SQL queries throughout
- Sales and purchases saved in a single transaction, so stock can never go negative
- Generic error messages for users, with details written to a local log file

## Tech stack

C# · .NET 8 · Windows Forms · SQL Server · ADO.NET · GitHub Actions

## Getting started

1. Install the [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) and SQL Server (Express is enough).
2. Create the database by running `sql/schema.sql`, then `sql/seed.sql` for demo data.
3. In `src/GestionDeStock/app.config`, replace `SERVERNAME` with your SQL Server instance (e.g. `.\SQLEXPRESS`).
4. Run the app with `dotnet run --project "src/GestionDeStock/Gestion de stock.csproj"`. The first account you sign up becomes the administrator.
