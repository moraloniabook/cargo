# Transportation System (Blazor Server)

این مخزن برای شروع یک سیستم حمل‌ونقل چندزبانه و ماژولار با تکنولوژی‌های روز (ASP.NET Core 8 + Blazor Server) آماده شده است. در این مرحله تمرکز روی **لایه دامنه** و **قراردادهای ماژولار** است تا ادامه‌ی توسعه مرحله‌به‌مرحله و قابل توسعه باشد.

## وضعیت فعلی
- ✅ لایه Domain با موجودیت‌ها و Enumهای کلیدی ایجاد شد.
- ✅ قراردادهای اولیه‌ی Repository و Payment Provider در لایه Application اضافه شد.
- ✅ یک نمونه‌ی Provider برای درگاه زرین‌پال در Infrastructure قرار گرفت (Placeholder).

## مراحل بعدی (یادآوری تا پایان پروژه)
1. **زیرساخت دیتابیس و EF Core** (DbContext، Migration، SQL Server).
2. **مدیریت چندزبانه (Resource-based i18n)** + پنل مدیریت زبان.
3. **UI اولیه Blazor Server** با MudBlazor (داشبورد و لیست سفارش‌ها).
4. **ماژول مالی و تسویه حساب رانندگان**.
5. **ماژول درگاه‌های پرداخت (Strategy + Factory)** و اتصال به درگاه‌های ایرانی.
6. **مستندات توسعه و استقرار (Deployment)**.

> من در هر مرحله شما را یادآوری می‌کنم تا پروژه کامل شود.

## ساختار پروژه
```
src/
  TransportationSystem.Domain/
  TransportationSystem.Application/
  TransportationSystem.Infrastructure/
  TransportationSystem.WebUI/
docs/
```

## راه‌اندازی
برای اجرای پروژه به .NET SDK 8 نیاز دارید. در این محیط SDK در دسترس نیست؛ لطفاً روی سیستم خودتان اجرا کنید.

```bash
# پس از نصب dotnet 8
cd src/TransportationSystem.WebUI
 dotnet restore
 dotnet run
```

## استانداردها
- Clean Architecture
- ماژولار بودن درگاه‌های پرداخت با Strategy Pattern
- آماده برای توسعه چندزبانه و تم تاریک/روشن
