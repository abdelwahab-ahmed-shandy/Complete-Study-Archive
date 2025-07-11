/*
===============================================================
🔹 ما هو HttpContext في ASP.NET Core؟
===============================================================
HttpContext هو كائن يحتوي على جميع المعلومات الخاصة بالطلب (Request) والاستجابة (Response) في ASP.NET Core.
يتم استخدامه للوصول إلى:
- بيانات الجلسة (Session).
- ملفات تعريف الارتباط (Cookies).
- بيانات الطلب (Request Data).
- بيانات الاستجابة (Response Data).
*/

/*
===============================================================
📌 أين يوجد HttpContext؟
===============================================================
في ASP.NET Core، يتم الوصول إلى HttpContext من خلال:
- Controller.
- Middleware.
- Razor Pages.

🔹 مثال: قراءة الـ User-Agent من الـ Headers في Controller
*/
public class HomeController : Controller
{
    public IActionResult Index()
    {
        string userAgent = HttpContext.Request.Headers["User-Agent"];
        return Content($"المتصفح: {userAgent}");
    }
}

/*
===============================================================
📌 مكونات HttpContext الأساسية:
===============================================================
*/

// (1) Request - بيانات الطلب
/*
🔹 يحتوي على معلومات مثل:
  - Headers
  - Query String
  - Cookies
  - Body
*/

🔹 قراءة عنوان IP للمستخدم:
*/
string ipAddress = HttpContext.Connection.RemoteIpAddress.ToString();

/*
🔹 قراءة قيمة من Query String:
إذا كان الرابط https://example.com/home?name=Shandy
فإن name ستحتوي على "Shandy"
*/
string name = HttpContext.Request.Query["name"];

/*
===============================================================
(2) Response - بيانات الاستجابة
===============================================================
يستخدم لإرسال البيانات إلى العميل مثل:
- إعداد الكوكيز.
- تغيير نوع المحتوى.
- إعادة التوجيه.
*/

// 🔹 إرسال نص بصيغة JSON إلى العميل
HttpContext.Response.ContentType = "application/json";
await HttpContext.Response.WriteAsync("{\"message\": \"Hello World\"}");

// 🔹 إعادة توجيه المستخدم
return Redirect("https://google.com");

/*
===============================================================
(3) Session - تخزين البيانات المؤقتة
===============================================================
تُستخدم الجلسة (Session) لتخزين بيانات المستخدم أثناء التنقل بين الصفحات.
*/

// 🔹 تخزين بيانات في الجلسة
HttpContext.Session.SetString("UserName", "Shandy");

// 🔹 قراءة البيانات من الجلسة
string userName = HttpContext.Session.GetString("UserName");

/*
===============================================================
(4) Cookies - تخزين بيانات على المتصفح
===============================================================
*/

// 🔹 إضافة كوكيز
HttpContext.Response.Cookies.Append("UserToken", "abc123");

// 🔹 قراءة كوكيز
string userToken = HttpContext.Request.Cookies["UserToken"];

/*
===============================================================
📌 متى يتم استخدام HttpContext؟
===============================================================
| الحالة                         | الاستخدام                                      |
|---------------------------------|-----------------------------------------------|
| الوصول إلى بيانات الطلب         | HttpContext.Request                          |
| إرسال استجابة مخصصة             | HttpContext.Response                         |
| تخزين بيانات المستخدم مؤقتًا     | HttpContext.Session                          |
| التعامل مع الكوكيز               | HttpContext.Request.Cookies و Response.Cookies |
| الوصول إلى بيانات المصادقة       | HttpContext.User                             |
*/

/*
===============================================================
📌 الخاتمة
===============================================================
- HttpContext هو كائن مركزي يحتوي على جميع البيانات الخاصة بالطلب والاستجابة.
- يُستخدم لقراءة الـ Headers, Query Strings, Cookies, و Sessions.
- يجب حقن IHttpContextAccessor عند الحاجة لاستخدامه خارج Controller.
*/

