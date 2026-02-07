# Roadmap (مرحله‌ای)

## فاز 1: پایه دامنه و قراردادها (انجام شد)
- موجودیت‌ها: Customer, Driver, Order, Payment, FinancialTransaction
- Enumهای کلیدی: OrderStatus, PaymentMethod, VehicleType, FinancialEntryType
- قرارداد Repositoryها و درگاه پرداخت

## فاز 2: زیرساخت دیتابیس و داده‌ها
- تعریف DbContext و تنظیم SQL Server
- پیاده‌سازی Repositoryها
- Migration اولیه

## فاز 3: ماژول پرداخت و سازگاری با درگاه‌های ایرانی
- الگوی Strategy + Factory
- پیاده‌سازی اولیه Zarinpal + PayPing + Sepehr
- ثبت تراکنش‌ها و تطبیق با سفارشات

## فاز 4: UI با Blazor Server + MudBlazor
- داشبورد ادمین
- مدیریت سفارشات، مشتریان، رانندگان
- تم روشن/تیره/خودکار

## فاز 5: چندزبانه و مدیریت ترجمه‌ها
- Resource Files
- صفحه مدیریت زبان‌ها و ترجمه‌ها

## فاز 6: گزارشات مالی و تسویه حساب
- بدهکار/بستانکار
- تسویه حساب رانندگان و گزارش‌گیری
