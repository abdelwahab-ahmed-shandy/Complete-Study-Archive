إذا كانت قاعدة البيانات موجودة مسبقًا، يمكنك استخدام Entity Framework لتوليد الكيانات تلقائيًا
If the database already exists, you can use the Entity Framework to automatically generate entities.



the sqlFirst :

//in Package Manager :
Scaffold-DbContext 'Data Source=.;Initial Catalog=BikeStores510;
Integrated Security=True;TrustServerCertificate=True'
 Microsoft.EntityFrameworkCore.SqlServer 
 -ContextDir Data -OutputDir Models -Context ApplicationDbContext

this is Scaffold With DataBase :

Scaffold-DbContext 'Data Source=.;Initial Catalog=P4 - Car Rental;Integrated Security=True;TrustServerCertificate=True' Microsoft.EntityFrameworkCore.SqlServer -ContextDir Data -OutputDir Models -Context CarRentalDbContext
