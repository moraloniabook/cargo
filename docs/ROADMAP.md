# Roadmap (Step-by-step delivery)

We will deliver the system **module by module**. Until all items are complete, I will keep reminding you of the remaining steps.

## Phase 1 — Foundation
- [ ] Create solution skeleton (Clean Architecture)
- [ ] Base configuration (appsettings, logging)
- [ ] Shared UI theme system (Light/Dark/Auto)
- [ ] i18n scaffolding (resource files + admin extensibility design)

## Phase 2 — UI Shell (Admin)
- [ ] Admin layout (sidebar/header)
- [ ] Dashboard with mock data
- [ ] Navigation and module shells

## Phase 3 — Core Domain + Application
- [ ] Domain entities (Order, Customer, Driver, Payment, Transaction)
- [ ] Business services (interfaces + DTOs)
- [ ] Validation rules

## Phase 4 — Infrastructure
- [ ] EF Core DbContext + migrations
- [ ] Repository/Unit of Work
- [ ] Payment provider interfaces (Strategy Pattern)

## Phase 5 — Admin Modules
- [ ] Orders management (CRUD + status flow)
- [ ] Customers management
- [ ] Drivers management
- [ ] Finance & settlement
- [ ] Payments & transactions
- [ ] Language management

## Phase 6 — Integrations & Hardening
- [ ] Iranian payment gateways (Zarinpal/PayPing/Sepehr)
- [ ] Authentication & Authorization
- [ ] Auditing & logs
- [ ] Automated tests
- [ ] Documentation & deployment

---

**Current status:** Phase 1 not started yet.
