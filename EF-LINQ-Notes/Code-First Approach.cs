يعني أنك تبدأ بتعريف الكيانات (الكلاسات) في الكود، ثم يقوم Entity Framework بإنشاء قاعدة البيانات بناءً على هذه الكيانات
This means that you start by defining entities (classes) in your code, and then Entity Framework creates the database based on these entities.

قبل عمل ال  Migration عليك التاكد من وجود :
Data Source=.;Initial Catalog=EFTest510;Integrated Security=True;TrustServerCertificate=True


داخل ال optionsBuilder.UseSqlServer :
في داخل ملف ال DbContext :
optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=EFTest510;Integrated Security=True;TrustServerCertificate=True");

حتي يتاكد انها هتسمع في قاعدة البيانات

بعدها يمكنك عمل : Migration
 و باستخدام أمر  Migration :

Add-Migration InitialCreate
Update-Database

يتم إنشاء جدول باسم Students في قاعدة البيانات
