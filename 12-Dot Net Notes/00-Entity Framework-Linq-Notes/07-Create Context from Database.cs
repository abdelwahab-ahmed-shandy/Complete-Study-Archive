

 تشغيل Scaffold-DbContext
افتح Package Manager Console (PMC) داخل Visual Studio أو استخدم CLI لتوليد DbContext والنماذج من قاعدة البيانات:

Scaffold-DbContext "Server=.;Database=DatabaseName;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -Context ApplicationDbContext


