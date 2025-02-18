Project and Structure :

📌 هيكلية مشروع ASP.NET Core MVC بعد الإنشاء
عند إنشاء مشروع ASP.NET Core MVC، يتم إنشاء مجموعة من المجلدات والملفات تلقائيًا. إليك الشكل العام لهيكل المشروع مع شرح واضح لكل مجلد وملف.

====================================
📂 مشروع ASP.NET Core MVC بعد الإنشاء
====================================

📦 MyMvcProject
│-- 📂 Connected Services
│-- 📂 Dependencies
│-- 📂 Properties
│   │-- launchSettings.json
│-- 📂 wwwroot
│   │-- 📂 css
│   │-- 📂 js
│   │-- 📂 images
│-- 📂 Controllers
│   │-- HomeController.cs
│-- 📂 Models
│   │-- User.cs
│-- 📂 Views
│   │-- 📂 Home
│   │   │-- Index.cshtml
│   │   │-- About.cshtml
│   │-- 📂 Shared
│   │   │-- _Layout.cshtml
│   │   │-- _ViewImports.cshtml
│   │   │-- _ViewStart.cshtml
│-- 📂 Views
│-- 📂 Areas
│   │-- 📂 Admin
│   │   │-- 📂 Controllers
│   │   │-- 📂 Views
│   │   │-- 📂 Models
│-- 📂 Data
│   │-- ApplicationDbContext.cs
│-- 📂 Migrations (إذا كنت تستخدم Entity Framework Core)
│-- 📂 Services (في حالة وجود خدمات مخصصة)
│-- appsettings.json
│-- appsettings.Development.json
│-- Program.cs
│-- Startup.cs (في بعض الإصدارات)
│-- MyMvcProject.csproj


===============================
📌 شرح مفصل لكل جزء من المشروع
===============================

📁 1️⃣ wwwroot/ (ملفات الاستاتيكية - Static Files)
📌 يحتوي على الملفات الثابتة التي يستخدمها الموقع مثل:
✔ css/ → ملفات التنسيق (CSS).
✔ js/ → ملفات JavaScript.
✔ images/ → صور المشروع.

💡 مهم جدًا: لا يمكنك استخدام الملفات داخله إلا إذا أضفت app.UseStaticFiles(); في Program.cs.

//============================================================================================================

📁 2️⃣ Controllers/ (التحكم في البيانات)
📌 يحتوي على الكنترولات (Controllers) وهي مسؤولة عن معالجة الطلبات وتمرر البيانات إلى Views.

✔ HomeController.cs:

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult About()
    {
        return View();
    }
}

💡 كل كنترولر يجب أن ينتهي بـ Controller حسب القواعد المتبعة.

//============================================================================================================

📁 3️⃣ Models/ (البيانات والكائنات)
📌 يحتوي على نماذج البيانات (Models) التي تمثل الكيانات داخل التطبيق.

✔ User.cs:

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
}

💡 يتم استخدام Models داخل Controllers و Views لعرض البيانات أو حفظها.

//============================================================================================================

📁 4️⃣ Views/ (واجهات المستخدم - Frontend)
📌 يحتوي على الواجهات (.cshtml)، حيث يتم عرض البيانات للمستخدم.

✔ هيكل Views/:

📂 Views
│-- 📂 Home
│   │-- Index.cshtml
│   │-- About.cshtml
│-- 📂 Shared
│   │---|
	│ 	│--_Layout.cshtml
│   │- _ViewImports.cshtml
│   │- _ViewStart.cshtml

============================================
✔ _Layout.cshtml (القالب الأساسي للموقع) :
============================================

<!DOCTYPE html>
<html lang="en">
<head>
    <title>@ViewData["Title"]</title>
    <link rel="stylesheet" href="~/css/site.css" />
</head>
<body>
    <header>
        <h1>My MVC Project</h1>
    </header>
    <div>
        @RenderBody()
    </div>
</body>
</html>

// 💡 هذا الملف يعمل كـ قالب موحد لكل الصفحات، ويتم استخدام @RenderBody() لعرض محتوى الصفحات.

=========================
ملف _ViewImports.cshtml
=========================

 هذا الملف يُستخدم لتضمين التوجيهات المشتركة (@using, @addTagHelper, إلخ) لجميع الصفحات (.cshtml) داخل مجلد Views.
🔹 بدلاً من إضافة @using أو @addTagHelper في كل صفحة، يتم تعريفها هنا مرة واحدة.

✔ مثال لمحتوى _ViewImports.cshtml:

@using MyMvcProject  // استخدام النيم سبيس الأساسي للمشروع
@using MyMvcProject.Models  // إتاحة الوصول إلى المودلز
@addTagHelper *, Microsoft.AspNetCore.Mvc.TagHelpers  // تفعيل الـ Tag Helpers

✅ ما يفعله هذا الملف:

يوفر الوصول إلى Models داخل جميع الـ Views.
يتيح استخدام Tag Helpers دون الحاجة إلى تعريفها في كل صفحة.

========================
 ملف _ViewStart.cshtml
========================

🔹 يحدد التخطيط (Layout) الافتراضي لجميع الـ Views، بدلاً من إضافته يدويًا في كل صفحة.
🔹 يتم تشغيل هذا الملف قبل كل View يتم تحميله، مما يسمح بتحديد القالب (_Layout.cshtml) مسبقًا.

✔ مثال لمحتوى _ViewStart.cshtml:

@{
    Layout = "_Layout";
}

✅ ما يفعله هذا الملف:

يحدد أن جميع الصفحات ستستخدم _Layout.cshtml كقالب رئيسي.
يمكن تخصيص التخطيط لكل View عبر تعديل Layout داخل الملف نفسه.

//============================================================================================================

🎯 ملخص سريع

_ViewImports.cshtml >>> 	يحدد التوجيهات المشتركة (@using, @addTagHelper).

_ViewStart.cshtml   >>> 	يحدد التخطيط (Layout) الافتراضي لكل الصفحات.


//============================================================================================================

💡 نصيحة:

إذا كنت بحاجة إلى View معين بدون تخطيط، يمكنك إلغاء التخطيط في الملف مباشرة:

@{
    Layout = null;
}

🚀 بهذا، يمكنك إدارة Views بشكل أكثر كفاءة في MVC! 🎯

//============================================================================================================
//============================================================================================================
//============================================================================================================