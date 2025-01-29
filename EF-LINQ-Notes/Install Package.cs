- Open Package Manager Console :  

EntityFrameworkCore
لإدارة قواعد البيانات باستخدام نهج الـ ORM (Object-Relational Mapping) :

Install-Package Microsoft.EntityFrameworkCore -Version 8.0.12

EntityFrameworkCore.SqlServer
إذا كنت تستخدم SQL Server كقاعدة بيانات :

Install-Package Microsoft.EntityFrameworkCore.SqlServer -Version 8.0.12

EntityFrameworkCore.Tools
لاستخدام الأوامر المتعلقة بـ EF Core مثل الترحيل (Migrations) :

Install-Package Microsoft.EntityFrameworkCore.Tools -Version 8.0.12

Microsoft.EntityFrameworkCore.Proxies
 يتم استخدامها في Entity Framework Core لتفعيل خاصية Lazy Loading : 
 
Install-Package Microsoft.EntityFrameworkCore.Proxies -Version 8.0.12











- Use the following command to view the list of installed packages : 
Get-Package 