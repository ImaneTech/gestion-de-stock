# Gestion de stock

[![Build](https://github.com/ImaneTech/gestion-de-stock/actions/workflows/build.yml/badge.svg)](https://github.com/ImaneTech/gestion-de-stock/actions/workflows/build.yml)

A Windows desktop inventory management application built with **C# / .NET 8 WinForms** and **SQL Server** (ADO.NET).
It covers products and stock levels, clients and suppliers, sales and purchases, invoices and monthly reports.

Team project (5 students). The user interface is in French.

## Demo

[Watch the demo](VIDEO_LINK)

## Features

- **Authentication**: sign-up and login with hashed passwords, admin/user roles and account lockout
- **Dashboard**: total stock value, paid invoices, number of clients and suppliers, low-stock alerts
- **Products**: add, update, delete and multi-criteria search, with minimum/maximum stock thresholds
- **Clients and suppliers**: add, update, delete and search by name
- **Sales and purchases**: cart with several products per operation; stock is updated atomically on confirmation
- **Invoices**: sale and purchase invoices with a paid/unpaid status
- **Reports**: monthly revenue, expenses and profit computed from invoices, colour-coded by result

## Tech stack

| Layer | Technology |
| --- | --- |
| UI | WinForms (.NET 8, `net8.0-windows`) |
| Data access | ADO.NET with `Microsoft.Data.SqlClient`, parameterized queries |
| Database | SQL Server / SQL Server Express |
| Security | PBKDF2-SHA256 (`Rfc2898DeriveBytes.Pbkdf2`), constant-time comparison |
| CI | GitHub Actions (build on `windows-latest`) |

## Project structure

```
gestion-de-stock/
├── .github/workflows/build.yml   CI build
├── sql/
│   ├── schema.sql                database and tables (re-runnable)
│   └── seed.sql                  demo data (re-runnable)
├── src/GestionDeStock/
│   ├── Forms/                    Auth, Main, Stock, Partners, Operations, Invoices, Reports
│   ├── Data/                     connection string and data-access helper
│   ├── Security/                 password hashing, password policy, session, error logging
│   ├── Resources/                icons and images
│   ├── Program.cs
│   ├── app.config
│   └── Gestion de stock.csproj
└── Gestion de stock.sln
```

## Getting started

### Prerequisites

- Windows
- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- SQL Server or SQL Server Express, plus SSMS or `sqlcmd`

### Setup

1. Clone the repository:
   ```bash
   git clone https://github.com/ImaneTech/gestion-de-stock.git
   cd gestion-de-stock
   ```
2. Create the database by running `sql/schema.sql`, then load the demo data with `sql/seed.sql`
   (in SSMS, or with `sqlcmd`):
   ```bash
   sqlcmd -S .\SQLEXPRESS -E -i sql/schema.sql
   sqlcmd -S .\SQLEXPRESS -E -i sql/seed.sql
   ```
   Both scripts can be run again safely. `schema.sql` also upgrades a database created with the old single script.
3. In `src/GestionDeStock/app.config`, replace `SERVERNAME` with your SQL Server instance (for example `.\SQLEXPRESS`).
   The database name is `GestionStock`.
4. Run the application:
   ```bash
   dotnet run --project "src/GestionDeStock/Gestion de stock.csproj"
   ```
5. Create an account on the sign-up screen. **The first account created becomes the administrator**;
   later accounts are regular users.

Errors are shown to the user as short generic messages. Full details are written to
`%LOCALAPPDATA%\GestionStock\logs\app.log`.

## Security notes

| Area | Before | Now |
| --- | --- | --- |
| Password storage | Plain text in the `users` table | PBKDF2-SHA256, 100,000 iterations, random 16-byte salt per user, constant-time comparison |
| Existing accounts | Plain-text passwords | Upgraded to a hash on the next successful login; the plain-text value is then cleared |
| Password policy | None; passwords were trimmed | At least 8 characters with letters and digits; passwords are no longer trimmed |
| Brute force | Unlimited login attempts | Account locked for 5 minutes after 5 failed attempts |
| Authorization | Any user could delete anything | Role column (`admin`/`user`); only admins can delete products, clients and suppliers |
| Session | No record of the logged-in user | `Session` object holds the current user; logout clears it and closes the main window |
| Error messages | Raw exception messages and stack traces shown to the user | Generic messages for the user; details logged to a local file |
| SQL injection | Parameterized queries | Unchanged: every query is parameterized |
| Data integrity | Sale/purchase lines and stock updated without a transaction; stock could go negative | One transaction per operation with rollback; stock re-checked at confirmation with a guarded update |

## Roadmap

- [x] Products, clients, suppliers, sales, purchases, invoices and reports
- [x] Several products per sale or purchase
- [x] Transactions and stock checks when confirming an operation
- [x] Hashed passwords, roles, password policy and account lockout
- [x] Generic error messages with local logging
- [x] Re-runnable `schema.sql` and `seed.sql`
- [x] Organized project structure and CI build
- [ ] Automated tests (unit tests for security and data access, integration tests against SQL Server)
- [ ] Delete and edit invoices (admin only)
- [ ] Hide or disable admin-only buttons for regular users
- [ ] User management screen for administrators
- [ ] Export reports to PDF or Excel
