//ملف GlobalUsing.cs هو جزء من ميزة global using directives التي تم تقديمها في C# 10. يسمح هذا الملف بتعريف توجيهات using التي سيتم استخدامها في جميع الملفات داخل المشروع، مما يقلل الحاجة إلى تكرارها في كل ملف cs.
// هذا الملف يعزز تنظيم الكود، ويقلل الحاجة إلى استيراد المكتبات الشائعة في كل ملف، مما يسهل إدارة المشروع.


global using Microsoft.EntityFrameworkCore; // لتسهيل استخدام EF Core وإدارة قواعد البيانات
global using Microsoft.AspNetCore.Mvc; // لاستيراد ASP.NET Core MVC ومعالجة الطلبات
global using Microsoft.AspNetCore.Mvc.Rendering; // لإنشاء عناصر HTML ديناميكية في العرض (Views)
global using System.ComponentModel.DataAnnotations; // لدعم التحقق من صحة البيانات (Validation)
global using System.Linq; // لاستخدام استعلامات LINQ بسهولة على المجموعات والكيانات
global using System.Collections.Generic; // لدعم القوائم والقواميس والمجموعات العامة
global using System.Threading.Tasks; // لدعم البرمجة غير المتزامنة باستخدام async/await
global using Newtonsoft.Json; // لتحويل الكائنات إلى JSON والعكس باستخدام Newtonsoft
global using System.Diagnostics; // لتسجيل الأحداث وتتبع الأداء أثناء تشغيل التطبيق
global using Microsoft.Extensions.Logging; // لدعم تسجيل الأخطاء والمعلومات في التطبيق


global using Microsoft.EntityFrameworkCore;
global using Microsoft.AspNetCore.Mvc;
global using Microsoft.AspNetCore.Mvc.Rendering;
global using System.ComponentModel.DataAnnotations;
global using System.Linq;
global using System.Collections.Generic;
global using System.Threading.Tasks;
global using Newtonsoft.Json;
global using System.Diagnostics;
global using Microsoft.Extensions.Logging;
