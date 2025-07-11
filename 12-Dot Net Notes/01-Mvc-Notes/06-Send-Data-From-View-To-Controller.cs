
📌 إرسال البيانات من الـ View إلى الـ Controller في ASP.NET Core MVC  :

-------------------------------------------------
1️ - باستخدام Parameters في URL (Query String) 📌
-------------------------------------------------

🔹 يمكن إرسال البيانات كـ معاملات (Parameters) في الـ URL عند إرسال طلب إلى Controller.

✔ مثال في الـ View (Index.cshtml):

<a asp-controller="Home" asp-action="Details" asp-route-id="10">عرض التفاصيل</a>

✔ مثال في الـ Controller (HomeController.cs):

public IActionResult Details(int id)
{
    return Content($"المعرف: {id}");
}

✅ النتيجة عند الضغط على الرابط:
المعرف: 10


⚠ متى نستخدمها؟
عند الحاجة لإرسال معاملات صغيرة في الطلبات (مثل ID أو نوع البحث).

//======================================================================================================

2️ - باستخدام Form - طريقة الـ POST 📌

🔹 يمكن إرسال البيانات باستخدام نموذج (Form) عند إدخال بيانات مثل التسجيل، تسجيل الدخول، البحث.

✔ مثال في الـ View (Index.cshtml):

<form asp-controller="Home" asp-action="SubmitData" method="post">
    <label>اسم المستخدم:</label>
    <input type="text" name="username" />
    <button type="submit">إرسال</button>
</form>


✔ مثال في الـ Controller (HomeController.cs):

[HttpPost]
public IActionResult SubmitData(string username)
{
    return Content($"تم استلام الاسم: {username}");
}


✅ النتيجة بعد إدخال الاسم "أحمد" والضغط على الإرسال:
تم استلام الاسم: أحمد

⚠ متى نستخدمها؟
عند الحاجة لإرسال بيانات غير ظاهرة في URL مثل كلمات المرور.

//======================================================================================================

3️ - باستخدام Model Binding 📌
🔹 Model Binding يسهل إرسال البيانات عند التعامل مع كائنات تحتوي على بيانات متعددة.

✔ إنشاء Model (User.cs):

public class User
{
    public string Name { get; set; }
    public int Age { get; set; }
}

✔ مثال في الـ View (Index.cshtml):

<form asp-controller="Home" asp-action="RegisterUser" method="post">
    <label>الاسم:</label>
    <input type="text" name="Name" />
    
    <label>العمر:</label>
    <input type="number" name="Age" />

    <button type="submit">تسجيل</button>
</form>

✔ مثال في الـ Controller (HomeController.cs):

[HttpPost]
public IActionResult RegisterUser(User user)
{
    return Content($"تم تسجيل: {user.Name} - العمر: {user.Age}");
}


✅ النتيجة عند إدخال "أحمد" والعمر "25":
تم تسجيل: أحمد - العمر: 25


⚠ متى نستخدمها؟
عند الحاجة لإرسال بيانات كبيرة أو معقدة.

//======================================================================================================

4️ - باستخدام AJAX (بدون إعادة تحميل الصفحة) 📌
🔹 AJAX يستخدم لإرسال البيانات دون إعادة تحميل الصفحة، مما يحسن تجربة المستخدم.

✔ مثال في الـ View (Index.cshtml):

<input type="text" id="username" placeholder="أدخل اسم المستخدم" />
<button onclick="sendData()">إرسال</button>

<script>
    function sendData() {
        var username = document.getElementById("username").value;

        fetch('/Home/SendData', {
            method: 'POST',
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify({ name: username })
        })
        .then(response => response.text())
        .then(data => alert(data));
    }
</script>


✔ مثال في الـ Controller (HomeController.cs):

[HttpPost]
public IActionResult SendData([FromBody] User user)
{
    return Content($"تم استلام: {user.Name}");
}


✅ النتيجة عند إدخال "أحمد" والضغط على الإرسال:
تم استلام: أحمد


⚠ متى نستخدمها؟
عند الحاجة إلى إرسال البيانات دون إعادة تحميل الصفحة.

//======================================================================================================

🎯 ملخص سريع

	الطريقة					الوصف							الاستخدام الأفضل
Query String		إرسال البيانات عبر الـ URL			عند إرسال ID أو بيانات بسيطة
Form - POST			إرسال البيانات عبر النموذج			عند الحاجة لحماية البيانات من الظهور في الـ URL
Model Binding		إرسال كائنات كاملة					عند التعامل مع بيانات معقدة
AJAX				إرسال البيانات بدون تحديث الصفحة	عند تحسين تجربة المستخدم


🚀 النصيحة:
استخدم Model Binding عند التعامل مع بيانات كبيرة أو معقدة.

استخدم AJAX لتحسين تجربة المستخدم وجعل التطبيقات أسرع.

استخدم Form - POST إذا كنت تريد إرسال بيانات بشكل آمن دون ظهورها في الـ URL.


//==========================================================================================================================
//==========================================================================================================================
Abdelwahab Shandy
//==========================================================================================================================
//==========================================================================================================================