# Architecture Overview

## Stack
- **ASP.NET Core 8 + Blazor Server**
- **SQL Server + EF Core**
- **MudBlazor UI**
- **Clean Architecture**

## Modules (high-level)
- **Orders**: create/assign/track orders
- **Customers**: profiles + financial accounts
- **Drivers**: registration, status, settlement
- **Finance**: debt/credit, commissions, settlements
- **Payments**: pluggable gateway providers
- **I18n**: multi-language + admin-managed translations

## Clean Architecture Structure (planned)
```
/ src
  / Domain
  / Application
  / Infrastructure
  / WebUI
```

## Extensibility goals
- Payment gateways via **Strategy Pattern**
- Domain events for order lifecycle
- Admin-managed translations (seeded + editable)
