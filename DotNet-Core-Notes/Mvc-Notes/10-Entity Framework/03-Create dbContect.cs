/*
=========================================
        دليل شامل لـ DbContext في Entity Framework Core
=========================================

DbContext هو العنصر الأساسي في Entity Framework Core، حيث يعمل كوسيط بين الكود وقاعدة البيانات.

🔹 الوظائف الرئيسية لـ DbContext:
----------------------------------
1️⃣ إدارة الاتصال بقاعدة البيانات.
2️⃣ تتبع الكيانات (Entities) وإدارتها.
3️⃣ تنفيذ عمليات CRUD (إضافة، تحديث، حذف، قراءة).
4️⃣ تطبيق Migrations لإنشاء وتحديث الجداول.

=========================================
1️⃣ - إنشاء ملف ApplicationDbContext
=========================================
*/

using Microsoft.EntityFrameworkCore;

namespace YourProjectNamespace.Data // استبدل YourProjectNamespace باسم مشروعك
{
    /// <summary>
    /// يمثل السياق الرئيسي لإدارة الاتصال بقاعدة البيانات.
    /// </summary>
    public class ApplicationDbContext : DbContext
    {
        /// <summary>
        /// يقوم بتمرير خيارات الاتصال عند إنشاء كائن DbContext.
        /// </summary>
        /// <param name="options">إعدادات الاتصال بقاعدة البيانات</param>
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options)
        {
        }

        /// <summary>
        /// تكوين الاتصال بقاعدة البيانات (اختياري عند استخدام Dependency Injection).
        /// </summary>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        /// <summary>
        /// تكوين العلاقات وإعدادات الجداول عند إنشاء الموديل.
        /// </summary>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        // تعريف الجداول (Entities)
        public DbSet<User> Users { get; set; } // جدول المستخدمين
        public DbSet<Product> Products { get; set; } // جدول المنتجات
    }
}

/*
=========================================
2️⃣ - إنشاء الكيانات (Entities)
=========================================
كل DbSet<T> في DbContext يمثل جدولًا في قاعدة البيانات.
يجب إنشاء كائن يمثل كل جدول.
*/

namespace YourProjectNamespace.Models
{
    /// <summary>
    /// يمثل كيان المستخدم في قاعدة البيانات.
    /// </summary>
    public class User
    {
        public int Id { get; set; } // المفتاح الأساسي
        public string Name { get; set; } // اسم المستخدم
        public string Email { get; set; } // البريد الإلكتروني
    }
}

namespace YourProjectNamespace.Models
{
    /// <summary>
    /// يمثل كيان المنتج في قاعدة البيانات.
    /// </summary>
    public class Product
    {
        public int Id { get; set; } // المفتاح الأساسي
        public string Name { get; set; } // اسم المنتج
        public decimal Price { get; set; } // سعر المنتج
    }
}

/*
=========================================
3️⃣ - ربط DbContext بقاعدة البيانات في ASP.NET Core
=========================================
يجب إضافة DbContext إلى Program.cs أو Startup.cs.
*/

using Microsoft.EntityFrameworkCore;
using YourProjectNamespace.Data;

var builder = WebApplication.CreateBuilder(args);

// إضافة DbContext إلى خدمات التطبيق
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

/*
🔹 إضافة الاتصال بقاعدة البيانات في appsettings.json:
*/

"ConnectionStrings": {
    "DefaultConnection": "Data Source=.;Initial Catalog=Database-Name;Integrated Security=True;TrustServerCertificate=True"
}
/*
📌 استبدل Database-Name باسم قاعدة البيانات الخاصة بك.

هذه هي سلسلة الاتصال (Connection String) الخاصة بقاعدة البيانات في SQL Server، والمستخدمة في appsettings.json لتكوين Entity Framework Core مع ASP.NET Core.

🔹 شرح المكونات:

"Data Source=." → يشير إلى الخادم المحلي (localhost)، يمكنك تغييره ليشير إلى خادم آخر.
"Initial Catalog=Database-Name" → اسم قاعدة البيانات، يجب استبداله بالاسم الفعلي لقاعدة البيانات.
"Integrated Security=True" → تعني استخدام مصادقة Windows بدلًا من اسم مستخدم وكلمة مرور.
"TrustServerCertificate=True" → يتم استخدامه عند الاتصال بخادم SQL مع شهادة غير موثوقة.

*/

/*
=========================================
4️⃣ - إنشاء قاعدة البيانات باستخدام Migrations
=========================================
بعد إعداد DbContext، يمكننا إنشاء قاعدة البيانات باستخدام Migrations.
*/

// افتح Package Manager Console ونفذ الأوامر التالية:
// Add-Migration InitialCreate  -> ينشئ ملف Migration لإنشاء الجداول.
// Update-Database  -> ينفذ Migration لإنشاء الجداول في قاعدة البيانات.

/*
=========================================
يمكنك الآن تنفيذ عمليات CRUD بسهولة على بيانات User و Product! ✅
*/
