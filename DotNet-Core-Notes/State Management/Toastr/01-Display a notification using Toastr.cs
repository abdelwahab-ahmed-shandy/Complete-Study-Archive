/*
===============================================================
📌 أمثلة إضافية على استخدام Toastr داخل ملفات JavaScript أو View
===============================================================
*/

<script>
    // عرض إشعار تحذيري بدون عنوان
    toastr.warning('My name is Inigo Montoya. You killed my father, prepare to die!');

    // عرض إشعار نجاح مع عنوان
    toastr.success('Have fun storming the castle!', 'Miracle Max Says');

    // عرض إشعار خطأ مع عنوان
    toastr.error('I do not think that word means what you think it means.', 'Inconceivable!');

    // إزالة جميع الإشعارات فورًا بدون تأثيرات
    toastr.remove();

    // إزالة جميع الإشعارات مع تأثيرات
    toastr.clear();

    // تجاوز الإعدادات الافتراضية لإشعار معين
    toastr.success('We do have the Kapua suite available.', 'Turtle Bay Resort', { timeOut: 5000 });
</script>

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
