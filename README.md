# Transportation Management System (Blazor Server)

This repository will be built **step-by-step** based on the requirements discussed. The end goal is a modular, multi-tenant-ready transportation platform with:

- **Blazor Server (ASP.NET Core 8)** UI
- **Clean Architecture** (Domain / Application / Infrastructure / WebUI)
- **SQL Server + EF Core**
- **Multi-language (i18n) with admin-managed languages**
- **Dark/Light/Auto themes**
- **Modular payment gateways (Strategy Pattern)**
- **Comprehensive documentation**

> We will implement features **one module at a time** and keep reminding you of remaining work until completion.

## How we will proceed
1. **Foundation**: solution structure, Clean Architecture projects, base config.
2. **UI shell**: Blazor layout, navigation, theme switcher, i18n scaffolding.
3. **Core modules**: Orders, Customers, Drivers, Payments, Finance.
4. **Admin panel**: dashboard, CRUD, reports.
5. **Integrations**: Iranian payment gateways (pluggable providers).
6. **Hardening**: auth, auditing, tests, documentation.

See the detailed plan: [docs/ROADMAP.md](docs/ROADMAP.md)
