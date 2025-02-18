علشان نعمل تهيئه للمشروع انه يشتغل MVC :

لازم نعمل بعض الخطوات ومنها :

1 - الذهاب الى ملف : Program.cs 

تقوم بتعديل الملف على النحو الاتي لتهيئته :

/*
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
    name: "admin",
    pattern: "{area:exists}/{controller=Home}/{action=Index}");
	
    endpoints.MapControllerRoute(
    name: "default",
    pattern: "{controller=Employees}/{action=List}/{id?}");
}
);

app.Run();

*/

// =============================================================================
تهيئة مشروع ASP.NET Core MVC في ملف Program.cs :
// =============================================================================

إنشاء وبناء التطبيق :

var builder = WebApplication.CreateBuilder(args);

🔹 هذا السطر ينشئ كائن builder الذي يُستخدم لإعداد التطبيق وإضافة الخدمات إليه.

// =============================================================================
 تفعيل MVC في المشروع :
 
builder.Services.AddControllersWithViews();

🔹 هذا السطر يخبر التطبيق بأننا سنستخدم نمط MVC، مما يسمح له بالتعامل مع Controllers و Views في المشروع.

✅ Services: تُستخدم لإضافة الخدمات الخارجية مثل ربط Class بـ Interface، أو استخدام قواعد البيانات، أو إضافة Authentication، وغيرها.

// =============================================================================
 بناء التطبيق وتشغيله :
 
 var app = builder.Build();

🔹 بعد الانتهاء من ضبط الخدمات، نقوم ببناء التطبيق ليصبح جاهزًا للتشغيل.

// =============================================================================
ضبط بيئة التطوير :

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error"); // معالجة الأخطاء في بيئة الإنتاج
    app.UseHsts(); // تفعيل HSTS لتحسين الأمان باستخدام HTTPS
}


🔹 app.Environment.IsDevelopment() يتحقق مما إذا كان المشروع في وضع التطوير.
🔹 إذا كان ليس في وضع التطوير، يتم تفعيل:

معالج الأخطاء (UseExceptionHandler) لتحويل المستخدم إلى صفحة /Home/Error عند حدوث خطأ.
UseHsts() لتحسين الأمان من خلال تفعيل HTTP Strict Transport Security (HSTS)

// =============================================================================
إجبار التطبيق على استخدام HTTPS :

app.UseHttpsRedirection();

🔹 يحوّل جميع الطلبات تلقائيًا إلى HTTPS بدلاً من HTTP، مما يحسن الأمان عبر SSL.

// =============================================================================
تفعيل استخدام الملفات الثابتة (Static Files) :

app.UseStaticFiles();

🔹 يتيح الوصول إلى الملفات الثابتة الموجودة داخل مجلد wwwroot، مثل:

الصور
ملفات CSS و JavaScript
أي ملفات ثابتة أخرى يحتاجها المشروع
📌 ملاحظة: لا يمكنك استخدام الملفات داخل wwwroot إلا بعد كتابة هذا السطر!

// =============================================================================
تفعيل نظام التوجيه (Routing) :

app.UseRouting();

🔹 يُستخدم لتحديد كيفية التعامل مع عناوين URL في المشروع.

// =============================================================================
 تفعيل صلاحيات الوصول (Authorization) :
 
 app.UseAuthorization();

🔹 يستخدم لتحديد من يمكنه الوصول إلى الصفحات المختلفة وفقًا لآليات المصادقة (Authentication) والتفويض (Authorization).
 
// =============================================================================
ضبط التوجيه (Routing Configuration) :

app.UseEndpoints(endpoints =>
{
    // منطقة (Area) مثل لوحة تحكم المشرف
    endpoints.MapControllerRoute(
        name: "admin",
        pattern: "{area:exists}/{controller=Home}/{action=Index}");

    // التوجيه الافتراضي
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Employees}/{action=List}/{id?}");
});

🔹 يحدد قواعد التوجيه لكيفية تعامل التطبيق مع الروابط (URLs):
✅ التوجيه الأول (admin): إذا كان هناك Area، يتم توجيه الطلب إلى HomeController > Index داخل تلك الـ Area.
✅ التوجيه الافتراضي (default): إذا لم يتم تحديد مسار، يتم توجيه الطلب تلقائيًا إلى EmployeesController > List مع إمكانية تمرير id كمعامل اختياري.

// =============================================================================
 تشغيل التطبيق :
 
 app.Run();

🔹 هذا هو السطر الذي يقوم فعليًا بتشغيل التطبيق والاستماع إلى الطلبات الواردة.

// =============================================================================
💡 النتيجة النهائية
بعد تنفيذ هذه الخطوات، سيكون مشروعك مُهيّأ للعمل بنمط MVC، مما يسمح له بمعالجة الطلبات باستخدام Controllers و Views بسلاسة. 
