// 1- Install Packet Identity 

/*
لتثبيت حزمة Microsoft.EntityFrameworkCore.NET الخاص بك، يمكنك استخدام إحدى الطريقتين:

الخيار 1: استخدام وحدة تحكم إدارة الحزم NuGet في Visual Studio:
1. افتح Visual Studio.
2. انتقل إلى "الأدوات" > "إدارة الحزم NuGet" > "وحدة تحكم إدارة الحزم".
3. نفّذ الأمر التالي:
*/
Install-Package Microsoft.EntityFrameworkCore -Version 8.0.12

// للتحقق من الحزمة المثبتة
Get-Package 

//====================================================================================================================
// 2- تعديل Entity Framework لدعم الهوية (Identity)

/*
  1. تعديل الفئة DbContext لترث من IdentityDbContext بدلاً من DbContext، وذلك لتمكين ASP.NET Identity.
     - يجب تحديد فئة المستخدم المخصصة (ApplicationUser) التي ترث من IdentityUser لإضافة حقول إضافية إذا لزم الأمر.
*/

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    // إضافة DbSet للكيانات الأخرى (إذا لزم الأمر)
    public DbSet<MyEntity> MyEntities { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder); // ضروري لضبط جداول Identity
        
        // إعداد جدول الكيان الإضافي (اختياري)
        modelBuilder.Entity<MyEntity>().ToTable("MyEntities");
    }
}

/*
2. إنشاء فئة المستخدم (ApplicationUser)
   - إذا كنت بحاجة إلى إضافة خصائص إضافية مثل الاسم الكامل أو تاريخ الميلاد، يمكنك تعريفها هنا.
*/

using Microsoft.AspNetCore.Identity;

public class ApplicationUser : IdentityUser
{
    public string FullName { get; set; } // حقل اختياري للاسم الكامل
    public DateTime DateOfBirth { get; set; } // حقل اختياري لتاريخ الميلاد
}

//====================================================================================================================
// 3 - تعديل Program.cs لإضافة خدمات الهوية (Identity)

/*
قم بتسجيل ApplicationDbContext وخدمات Identity في حاوية الاعتمادية (Dependency Injection) داخل Program.cs
*/

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// إعداد اتصال قاعدة البيانات
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

// إضافة خدمات الهوية (Identity)
builder.Services.AddIdentity<ApplicationUser, IdentityRole>(options =>
{
    // إعدادات كلمة المرور
    options.Password.RequireUppercase = true; // يجب أن تحتوي كلمة المرور على حرف كبير على الأقل
    options.Password.RequireNonAlphanumeric = true; // يجب أن تحتوي كلمة المرور على رمز خاص (@، #، !، إلخ)
    options.Password.RequiredLength = 8; // الحد الأدنى للطول 8 أحرف

    // إعدادات المستخدم
    options.User.RequireUniqueEmail = true; // يجب أن يكون البريد الإلكتروني فريدًا لكل مستخدم
})
.AddEntityFrameworkStores<ApplicationDbContext>() // ربط الهوية بقاعدة البيانات باستخدام EF Core
.AddDefaultTokenProviders(); // تفعيل مزودات التوكن لدعم إعادة تعيين كلمة المرور وتأكيد البريد الإلكتروني

// إضافة خدمات MVC
builder.Services.AddControllersWithViews();

var app = builder.Build();

// إعداد خطوط الـ HTTP
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication(); // تفعيل المصادقة
app.UseAuthorization();  // تفعيل التفويض

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

//====================================================================================================================
// 4 - إنشاء الجداول في قاعدة البيانات عبر Migrations

/*
لإنشاء الجداول المطلوبة من قبل ASP.NET Identity، استخدم الأوامر التالية في وحدة التحكم Package Manager Console:
*/

Add-Migration AddIdentityTables // إنشاء الترحيل الأولي (Migration) لإضافة جداول الهوية

Update-Database // تطبيق التغييرات على قاعدة البيانات
