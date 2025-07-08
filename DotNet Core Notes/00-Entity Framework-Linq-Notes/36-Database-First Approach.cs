
إذا كانت قاعدة البيانات موجودة مسبقًا، يمكنك استخدام Entity Framework لتوليد الكيانات تلقائيًا
If the database already exists, you can use the Entity Framework to automatically generate entities.



the sqlFirst :

// In Package Manager :
Scaffold-DbContext 'Data Source=.;Initial Catalog=BikeStores510;
Integrated Security=True;TrustServerCertificate=True'
 Microsoft.EntityFrameworkCore.SqlServer 
 -ContextDir Data -OutputDir Models -Context ApplicationDbContext

// This is Scaffold With DataBase :

Scaffold-DbContext 'Data Source=.;Initial Catalog=QuickTickets-DB;Integrated Security=True;TrustServerCertificate=True' Microsoft.EntityFrameworkCore.SqlServer -ContextDir Data -OutputDir Models -Context ApplicationDbContext
