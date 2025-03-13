// 1- Install Packet Identity 

/*لتثبيت حزمة Microsoft.EntityFrameworkCore الإصدار 8.0.12 في مشروع .NET الخاص بك، يمكنك استخدام وحدة تحكم إدارة الحزم NuGet في Visual Studio أو واجهة سطر أوامر .NET في الطرفية.

الخيار 1: استخدام وحدة تحكم إدارة الحزم NuGet
افتح Visual Studio.

انتقل إلى الأدوات > إدارة الحزم NuGet > وحدة تحكم إدارة الحزم.

نفّذ الأمر التالي:
*/

Install-Package Microsoft.EntityFrameworkCore -Version 8.0.12

//====================================================================================================================
//====================================================================================================================
// 2- modify Entity Framework 
/*
  1. تعديل الفئة DbContext لترث من IdentityDbContext
بدلاً من أن ترث من DbContext، قم بتعديل الفئة لترث من IdentityDbContext مع تحديد فئة المستخدم (ApplicationUser) التي ترث من IdentityUser.
*/

//------------------------------------------------------------------------------------
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    // إضافة DbSet للكيانات الأخرى (اختياري)
    public DbSet<MyEntity> MyEntities { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder); // ضروري لإعداد جداول Identity

        // إعدادات إضافية للكيانات الأخرى (اختياري)
        modelBuilder.Entity<MyEntity>().ToTable("MyEntities");
    }
}
//------------------------------------------------------------------------------------

/*
2. إنشاء فئة المستخدم (ApplicationUser)
إذا لم تكن قد قمت بإنشائها بعد، قم بإنشاء فئة المستخدم التي ترث من IdentityUser. يمكنك إضافة خصائص مخصصة إذا لزم الأمر.
*/

//------------------------------------------------------------------------------------
using Microsoft.AspNetCore.Identity;

public class ApplicationUser : IdentityUser
{
    // إضافة خصائص مخصصة (اختياري)
    public string FullName { get; set; }
    public DateTime DateOfBirth { get; set; }
}
//------------------------------------------------------------------------------------


//====================================================================================================================
//====================================================================================================================
// 3 - Edit Program.cs to add Identity

/*
تعديل Program.cs لإضافة Identity
قم بتسجيل ApplicationDbContext وخدمات Identity في حاوية الاعتمادية (Dependency Injection).
*/

//------------------------------------------------------------------------------------
//using Microsoft.AspNetCore.Identity;
//using Microsoft.EntityFrameworkCore;

//var builder = WebApplication.CreateBuilder(args);

// إعدادات قاعدة البيانات
//var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
//builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

// إضافة Identity
builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders();

// إضافة خدمات التحكم والعرض
//builder.Services.AddControllersWithViews();

//var app = builder.Build();

// تكوين خطوط HTTP
//if (!app.Environment.IsDevelopment())
//{
  //  app.UseExceptionHandler("/Home/Error");
  //  app.UseHsts();
//}

//app.UseHttpsRedirection();
//app.UseStaticFiles();

//app.UseRouting();

app.UseAuthentication(); // تمكين المصادقة
app.UseAuthorization();  // تمكين التفويض

//app.MapControllerRoute(
  //  name: "default",
  //  pattern: "{controller=Home}/{action=Index}/{id?}");

//app.Run();
//------------------------------------------------------------------------------------


