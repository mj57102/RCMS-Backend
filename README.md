
# RCMS Backend 005 (فارسی)
این بسته شامل بک‌اند کامل بر پایه **.NET 8 + Dapper + Stored Procedures** برای سناریوی چندمستاجری (SaaS) است.

## محتویات
- **RCMS.sln** + ۶ پروژه: Domain, Application, Infrastructure, API, Common, Tests
- موجودیت‌های کامل برای ۳۶ جدول با **DisplayName فارسی** و توضیحات
- DTO/Service/Repository/Controller برای همه‌ی موجودیت‌ها
- **Swagger فارسی** و تولید XML Docs
- **sql/schema.sql** و **sql/seed.sql** (ایجاد جداول + SPهای CRUD + داده‌های اولیه)

## شروع سریع
1. دیتابیس `RCMS` بسازید و `sql/schema.sql` را اجرا کنید.
2. سپس `sql/seed.sql` را اجرا کنید.
3. در `RCMS.API/appsettings.json` کانکشن‌استرینگ را تنظیم کنید.
4. پروژه `RCMS.API` را اجرا کنید → Swagger در `/swagger` در دسترس است.
