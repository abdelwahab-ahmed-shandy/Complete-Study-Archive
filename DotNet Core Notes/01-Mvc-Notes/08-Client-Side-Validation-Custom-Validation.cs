
// 🔹 التحقق من صحة البيانات على جهة العميل (Client-Side Validation) في ASP.NET Core MVC
--------------------------------------

في جزء Client-Side Validation , اهم جزئيتين هما :

1- اضافه ملفات JQuery .

2- استخدام [ValidateAntiForgeryToken]

--------------------------------------

📌 ما هو Client-Side Validation؟
التحقق من صحة البيانات على جهة العميل هو عملية فحص   المدخلات قبل إرسالها إلى الخادم باستخدام JavaScript و jQuery.
يتم ذلك لتحسين تجربة المستخدم عن طريق عرض الأخطاء مباشرةً دون الحاجة إلى إعادة تحميل الصفحة.

📌 كيفية تفعيل التحقق على جهة العميل في ASP.NET Core MVC
في ASP.NET Core MVC، يتم التحقق من البيانات على العميل باستخدام jQuery Validation و Unobtrusive Validation، وهي مكتبات تقوم بتحويل Data Annotations إلى قواعد تحقق في المتصفح.



🎯 كيفية تفعيل Client-Side Validation في ASP.NET Core MVC
//==========================================================================================================================
////// مهم جداااا 

1️ - تفعيل التحقق على جهة العميل في View
يجب تضمين مكتبات jQuery Validation في المشروع، وهي مضمنة تلقائيًا في ASP.NET Core.

🎯 1️ - إضافة مكتبات jQuery Validation : 
قبل أن يعمل Client-Side Validation، يجب تضمين ملفات jQuery و jQuery Validation في المشروع.
🔹 يتم تضمينها تلقائيًا عند إنشاء المشروع، ولكن إذا لم تكن مضافة، قم بإضافتها يدويًا:

<script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/jquery-validate/1.19.3/jquery.validate.min.js"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/jquery-validation-unobtrusive/3.2.11/jquery.validate.unobtrusive.min.js"></script>

✅ هذه المكتبات مسؤولة عن تنفيذ التحقق على العميل قبل إرسال البيانات للخادم.  
//==========================================================================================================================

///////////هذا جزء سيرفر سايد اكثر وله ملف اخر لشرحه

🎯 2️ - تطبيق Client-Side Validation في النموذج
في Model، نستخدم Data Annotations لتحديد قواعد التحقق.

🔹 مثال على نموذج يحتوي على التحقق من الصحة:

using System.ComponentModel.DataAnnotations;

public class UserModel
{
    [Required(ErrorMessage = "الاسم مطلوب!")]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "يجب أن يكون الاسم بين 3 و 50 حرفًا.")]
    public string Name { get; set; }

    [Required(ErrorMessage = "البريد الإلكتروني مطلوب!")]
    [EmailAddress(ErrorMessage = "البريد الإلكتروني غير صالح!")]
    public string Email { get; set; }

    [Required(ErrorMessage = "كلمة المرور مطلوبة!")]
    [MinLength(6, ErrorMessage = "يجب أن تكون كلمة المرور 6 أحرف على الأقل.")]
    public string Password { get; set; }
}

✅ هذه التعليقات التوضيحية (Data Annotations) سيتم تحويلها تلقائيًا إلى تحقق على جهة العميل بواسطة jQuery Validation.


//==========================================================================================================================

///////////هذا جزء سيرفر سايد اكثر وله ملف اخر لشرحه


🎯 3️ - إنشاء View مع دعم التحقق من صحة البيانات على العميل
🔹 مثال على Register.cshtml يحتوي على حقول الإدخال وعرض الأخطاء:

------------------------------------------------------------------
@model UserModel

<form asp-action="Register" asp-controller="User" method="post">
    <div>
        <label asp-for="Name"></label>
        <input asp-for="Name" />
        <span asp-validation-for="Name" class="text-danger"></span>
    </div>

    <div>
        <label asp-for="Email"></label>
        <input asp-for="Email" />
        <span asp-validation-for="Email" class="text-danger"></span>
    </div>

    <div>
        <label asp-for="Password"></label>
        <input asp-for="Password" type="password" />
        <span asp-validation-for="Password" class="text-danger"></span>
    </div>

    <button type="submit">تسجيل</button>
</form>
------------------------------------------------------------------

✅ عند إدخال بيانات غير صحيحة، سيعرض المتصفح رسائل الخطأ بدون إرسال البيانات إلى الخادم.

//==========================================================================================================================

🎯 4️ - التأكد من تمكين التحقق في ViewImports

يجب التأكد من أن ملف _ViewImports.cshtml يحتوي على:

---------------------------------------------------------
@addTagHelper *, Microsoft.AspNetCore.Mvc.TagHelpers
---------------------------------------------------------
✅ هذا يضمن أن Tag Helpers مثل asp-validation-for تعمل بشكل صحيح.

//==========================================================================================================================

🎯 5️ - إضافة التحقق المخصص على جهة العميل
إذا كنت بحاجة إلى تحقق مخصص لا تغطيه Data Annotations، يمكنك إنشاؤه باستخدام jQuery Validation.

🔹 مثال:
 إضافة قاعدة تحقق مخصصة في site.js للتأكد من أن الاسم يبدأ بحرف كبير:

--------------------------------------------------------------------
$.validator.addMethod("capitalletter", function (value, element) {
    return this.optional(element) || /^[A-Z].*$/.test(value);
}, "يجب أن يبدأ الاسم بحرف كبير!");
--------------------------------------------------------------------

ثم نربطها بالعنصر المطلوب في الصفحة:

<script>
    $(document).ready(function () {
        $("input[name='Name']").rules("add", { capitalletter: true });
    });
</script>

✅ بهذه الطريقة، سيتم التحقق من أن الاسم يبدأ بحرف كبير دون الحاجة إلى إرسال البيانات للخادم.

//==========================================================================================================================
////// مهم جداااا 

🎯 6️ - التحكم في إرسال البيانات إلى الخادم
🔸 استخدام [HttpPost] و [ValidateAntiForgeryToken]
عند إرسال النموذج، يجب حمايته من هجمات CSRF باستخدام [ValidateAntiForgeryToken]، حيث يقوم بالتحقق من صحة الطلب.

🔹 مثال على Controller مع حماية CSRF:

--------------------------------------------------------------------
using Microsoft.AspNetCore.Mvc;

public class UserController : Controller
{
    [HttpGet]
    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken] // حماية ضد CSRF
    public IActionResult Register(UserModel model)
    {
        if (!ModelState.IsValid) // إذا كان هناك خطأ، إعادة عرض النموذج
        {
            return View(model);
        }

        return RedirectToAction("Success");
    }

    public IActionResult Success()
    {
        return View();
    }
}
--------------------------------------------------------------------
✅ هنا يتم التحقق من صحة البيانات على العميل أولاً، ثم يتم إرسالها إلى الخادم إذا لم تكن هناك أخطاء.
✅ [ValidateAntiForgeryToken] يحمي النموذج من هجمات تزوير الطلبات بين المواقع (CSRF).

//==========================================================================================================================

📌 ملخص سريع
✔ Client-Side Validation يستخدم jQuery Validation للتحقق من المدخلات قبل إرسالها إلى الخادم.
✔ يجب تضمين مكتبات jQuery و jQuery Validation في الصفحة.
✔ يتم تطبيق Data Annotations في Model ويتم تحويلها إلى تحقق على العميل تلقائيًا.
✔ يمكن إضافة تحقق مخصص باستخدام $.validator.addMethod().
✔ عند إرسال البيانات، يتم التحقق من CSRF باستخدام [ValidateAntiForgeryToken].

//==========================================================================================================================
//==========================================================================================================================
Abdelwahab Shandy
//==========================================================================================================================
//==========================================================================================================================