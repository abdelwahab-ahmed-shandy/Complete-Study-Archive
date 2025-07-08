/*
===============================================================
🔹 Toastr.js - إشعارات جميلة وسهلة الاستخدام
===============================================================
📌 رابط المشروع:
https://github.com/CodeSeven/toastr
*/

/*
===============================================================
📌 تثبيت Toastr.js في المشروع
===============================================================
أضف الروابط التالية إلى ملف _Layout.cshtml:
*/

/*
✅ في <head> داخل _Layout.cshtml:
*/
<!-- Toastr CSS -->
<link href="https://cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/toastr.min.css" rel="stylesheet"/>

/*
✅ في نهاية الـ <body> داخل _Layout.cshtml:
*/
<!-- jQuery (ضروري لتشغيل Toastr) -->
<script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.6.0/jquery.min.js"></script>

<!-- Toastr JS -->
<script src="https://cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/toastr.min.js"></script>

/*
===============================================================
🔥 🎯 ملخص سريع
===============================================================
✅ أضف Toastr إلى _Layout.cshtml (CSS في <head> و JS في نهاية body).
✅ استخدم TempData لإرسال إشعارات بين الصفحات بعد عمليات Redirect.
✅ استخدم toastr.success(), toastr.error() وغيرها في ملفات الـ View أو JavaScript الخارجي.
✅ استخدم @section Scripts في أي View عند الحاجة.
✅ خصص الإعدادات مثل المدة، الموضع، والتأثيرات حسب الحاجة.
*/