📌 ما هو DbContext؟
DbContext هو قلب Entity Framework Core، حيث يعمل كوسيط بين قاعدة البيانات والكود الخاص بك.
🔹 يوفر DbContext الوظائف التالية:

إدارة الاتصال بقاعدة البيانات.
تتبع الكيانات (Entities) وإدارتها.
تنفيذ عمليات CRUD (إدراج، تحديث، حذف، قراءة).
تطبيق عمليات الترحيل (Migrations) لإنشاء الجداول وتحديثها.

//=========================================================================================================================================

1️ - إنشاء ملف ApplicationDbContext :
======================================

بعد تثبيت Entity Framework Core، تحتاج إلى إنشاء فئة DbContext داخل مشروعك.

📌 الخطوات:

أنشئ مجلدًا جديدًا في مشروعك باسم Data (اختياري لكنه منظم).
داخل المجلد، أنشئ ملفًا جديدًا باسم ApplicationDbContext.cs.
أضف الكود التالي:

using Microsoft.EntityFrameworkCore;

namespace YourProjectNamespace.Data // استبدل YourProjectNamespace باسم مشروعك
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options)
        {
        }

        // تعريف الجداول (DbSets)
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}

🔹 شرح الكود:
✔ ApplicationDbContext ترث من DbContext، مما يجعلها مسؤولة عن إدارة الاتصال بقاعدة البيانات.
✔ DbSet<User> Users يمثل جدول المستخدمين، و DbSet<Product> Products يمثل جدول المنتجات.
✔ DbContextOptions<ApplicationDbContext> options يستخدم لتمرير إعدادات الاتصال بقاعدة البيانات عند تشغيل التطبيق.

//=========================================================================================================================================

2️ - إنشاء كائنات (Entities) :
===========================

كل DbSet<T> في DbContext يمثل جدولًا في قاعدة البيانات، ويحتاج إلى كائن يمثل بيانات الجدول.

🔹 إنشاء ملف User.cs داخل مجلد Models:

namespace YourProjectNamespace.Models
{
    public class User
    {
        public int Id { get; set; } // المفتاح الأساسي
        public string Name { get; set; }
        public string Email { get; set; }
    }
}


🔹 إنشاء ملف Product.cs داخل مجلد Models:

namespace YourProjectNamespace.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}

📌 ملاحظات:
✔ كل كائن يمثل جدولًا، وكل خاصية تمثل عمودًا داخل الجدول.
✔ Id هو المفتاح الأساسي تلقائيًا (يمكن تغييره باستخدام Data Annotations).


//=========================================================================================================================================

3️ - ربط DbContext بقاعدة البيانات :
=================================
يجب إضافة DbContext إلى Program.cs أو Startup.cs في مشروع ASP.NET Core.

🔹 افتح Program.cs (في ASP.NET Core 6 وما بعده):

---------------------------------------------------------------------------------------------------
using Microsoft.EntityFrameworkCore;
using YourProjectNamespace.Data;

var builder = WebApplication.CreateBuilder(args);

// إضافة DbContext وخيارات الاتصال بقاعدة البيانات
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();
---------------------------------------------------------------------------------------------------

🔹 إضافة الاتصال بقاعدة البيانات في appsettings.json:

-----------------------------------------------------------------------------------------------------------------
"ConnectionStrings": {
    "DefaultConnection": "Data Source=.;Initial Catalog=Database-Name;Integrated Security=True;TrustServerCertificate=True"
}
------------------------------------------------------------------------------------------------------------------

📌 استبدل MyDatabase باسم قاعدة البيانات الخاصة بك.


//=========================================================================================================================================

4️ - إنشاء قاعدة البيانات باستخدام Migrations :
==========================================
بعد إعداد DbContext، يمكننا إنشاء قاعدة البيانات باستخدام Migrations.

🔹 افتح Package Manager Console ونفّذ الأوامر التالية:

------------------------------
Add-Migration InitialCreate   |
Update-Database               |
------------------------------

✔ Add-Migration InitialCreate  : ينشئ ملف Migration يحتوي على التعليمات البرمجية اللازمة لإنشاء الجداول.
✔ Update-Database  : ينفذ Migration ويقوم بإنشاء الجداول في قاعدة البيانات.

//=========================================================================================================================================

📌 أصبح لديك الآن DbContext متكامل لإدارة بياناتك باستخدام Entity Framework Core! ✅
💡 يمكنك الآن تنفيذ عمليات CRUD بسهولة على بيانات User و Product.