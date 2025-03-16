/*==========================================================
📌 دمج Toastr.js مع ASP.NET Core لعرض الإشعارات
==========================================================*/

/*=================================================================================
عرض الإشعارات في Index.cshtml أو أي View أخرى
يمكنك تضمين كود Toastr داخل ملف View مثل Index.cshtml أو في ملف JavaScript خارجي.
===================================================================================*/

//📌 في AnyPageView.cshtml

@section Scripts {
<script>
    $(document).ready(function () {
        // قراءة القيم من TempData وإزالة الفراغات الزائدة
        var message = '@TempData["notifiction"]'.trim();
        var messageType = '@TempData["MessageType"]'.trim();

        // التحقق من وجود رسالة فعلية
        if (message && message !== 'null' && message !== 'undefined' && message !== '') {
            switch (messageType.toLowerCase()) {
                case 'success':
                    toastr.success(message, 'Success');
                    break;
                case 'error':
                    toastr.error(message, 'Error');
                    break;
                case 'warning':
                    toastr.warning(message, 'Warning');
                    break;
                default:
                    toastr.info(message, 'Notice');
            }
        }
    });
</script>
}

//=======================================================================================================================
//=======================================================================================================================
/*========================================
✅ 3. تعيين قيم TempData في Controller

🔹 في Create داخل CategoryController
========================================*/

[HttpPost]
[ValidateAntiForgeryToken]
public IActionResult Create(Category category)
{
    if (ModelState.IsValid)
    {
        _categoryRepository.Create(category);
        _categoryRepository.SaveDB();

        TempData["notifiction"] = "The category was created successfully!";
        TempData["MessageType"] = "success";

        return RedirectToAction(nameof(Index));
    }
    TempData["Message"] = "An error occurred while creating the category!";
    TempData["MessageType"] = "error";

    return View(category);
}


/*==================================
🔹 في Edit داخل CategoryController
==================================*/

[HttpPost]
[ValidateAntiForgeryToken]
public IActionResult Edit(Category category)
{
    if (category == null || !ModelState.IsValid)
    {
        TempData["notifiction"] = "Category not found!";
        TempData["MessageType"] = "error";
        return RedirectToAction("NotFound", "Home");
    }

    _categoryRepository.Edit(category);
    _categoryRepository.SaveDB();

    TempData["notifiction"] = "Edit Category Successfully!";
    TempData["MessageType"] = "success";

    return RedirectToAction(nameof(Index));
}

/*====================================
🔹 في Delete داخل CategoryController
====================================*/

public IActionResult Delete(int Id)
{
    var category = _categoryRepository.GetOne(c => c.Id == Id);
    
    if (category == null)
    {
        return RedirectToAction("NotFound", "Home");
    }
    
    _categoryRepository.Delete(category);
    _categoryRepository.SaveDB();

    TempData["notifiction"] = "Category Deleted Successfully!";
    TempData["MessageType"] = "success";
    
    return RedirectToAction(nameof(Index));
}


/*==============================================================================================================
🔥 🎯 ملخص سريع:

✅ أضف Toastr إلى _Layout.cshtml (CSS في <head> و JS في نهاية <body>).
✅ استخدم TempData لإرسال إشعارات بين الصفحات بعد عمليات Redirect.
✅ استخدم toastr.success(), toastr.error() وغيرها في ملفات الـ View أو JavaScript الخارجي.
✅ استخدم @section Scripts في أي View عند الحاجة.✅ خصص الإعدادات مثل المدة، الموضع، التأثيرات حسب الحاجة.
==============================================================================================================*/