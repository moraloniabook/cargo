# Roadmap

این سند، مسیر اجرای مرحله‌ای پروژه را مشخص می‌کند.

## فاز 0: برنامه‌ریزی و اسکلت پروژه (انجام شد)
- ایجاد ساختار پوشه‌ها
- ثبت الزامات کلیدی

## فاز 1: Domain Layer
- تعریف موجودیت‌ها (Order, Customer, Driver, Payment, Transaction)
- Value Objects و Enums پایه
- اینترفیس‌های دامنه (IDomainEvent, IEntity)

## فاز 2: Application Layer
- DTOها
- سرویس‌های کاربردی
- قوانین و اعتبارسنجی‌ها
- Use Caseها (CQRS سبک)

## فاز 3: Infrastructure Layer
- EF Core + SQL Server
- پیاده‌سازی Repositoryها
- سیستم درگاه‌های پرداخت (Strategy)

## فاز 4: WebUI (Blazor Server)
- تم روشن/تیره/خودکار
- چندزبانه (fa/en) + مدیریت زبان‌ها
- داشبورد ادمین (Mock Data)

## فاز 5: مستندات نهایی
- راهنمای نصب و استقرار
- راهنمای توسعه و افزودن ماژول‌ها
