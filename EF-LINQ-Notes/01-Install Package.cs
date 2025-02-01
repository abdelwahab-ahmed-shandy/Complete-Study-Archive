// Open Package Manager Console :  

// EntityFrameworkCore
// لإدارة قواعد البيانات باستخدام نهج الـ ORM (Object-Relational Mapping) :

Install-Package Microsoft.EntityFrameworkCore -Version 8.0.12

// EntityFrameworkCore.SqlServer
// إذا كنت تستخدم SQL Server كقاعدة بيانات :

Install-Package Microsoft.EntityFrameworkCore.SqlServer -Version 8.0.12

// EntityFrameworkCore.Tools
// لاستخدام الأوامر المتعلقة بـ EF Core مثل الترحيل (Migrations) :

Install-Package Microsoft.EntityFrameworkCore.Tools -Version 8.0.12

// Microsoft.EntityFrameworkCore.Proxies
// يتم استخدامها في Entity Framework Core لتفعيل خاصية Lazy Loading : 
 
Install-Package Microsoft.EntityFrameworkCore.Proxies -Version 8.0.12


// You can use the following to install this pack easily: 

// Go to any old project you will find a file with the extension : .csproj
// Take the files between the brackets below: 
// Put it in the main file :

  <ItemGroup>
    <PackageReference Include="Microsoft.EntityFrameworkCore" Version="8.0.12" />
    <PackageReference Include="Microsoft.EntityFrameworkCore.Proxies" Version="8.0.12" />
    <PackageReference Include="Microsoft.EntityFrameworkCore.SqlServer" Version="8.0.12" />
    <PackageReference Include="Microsoft.EntityFrameworkCore.Tools" Version="8.0.12">
    <PrivateAssets>all</PrivateAssets>
    <IncludeAssets>runtime; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>
    </PackageReference>
  </ItemGroup>
  
// What changes is only the files inside.
// In other words, according to the package you installed.

//Use the following command to view the list of installed packages : 
Get-Package 
