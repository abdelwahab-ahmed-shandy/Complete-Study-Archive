🔹 تثبيت Entity Framework Core باستخدام NuGet Package Manager
📌 فتح Package Manager Console
للبدء، افتح Visual Studio ثم انتقل إلى:
Tools → NuGet Package Manager → Package Manager Console.

//=========================================================================================================================================

1️ - تثبيت Entity Framework Core
🔹 EntityFrameworkCore
هذه الحزمة الأساسية لـ Entity Framework Core، والتي توفر إمكانيات ORM (Object-Relational Mapping) للتعامل مع قواعد البيانات باستخدام كود C#. :

Install-Package Microsoft.EntityFrameworkCore -Version 8.0.12

//=========================================================================================================================================

2️ - تثبيت موفر قاعدة البيانات (SQL Server)
🔹 EntityFrameworkCore.SqlServer
إذا كنت تستخدم SQL Server كقاعدة بيانات، فأنت بحاجة إلى تثبيت هذا الموفر.

Install-Package Microsoft.EntityFrameworkCore.SqlServer -Version 8.0.12

//=========================================================================================================================================

3️ - تثبيت الأدوات اللازمة لتنفيذ عمليات الترحيل (Migrations)
🔹 EntityFrameworkCore.Tools
هذه الحزمة ضرورية لاستخدام الأوامر الخاصة بـ EF Core مثل Migrations و Scaffolding :

Install-Package Microsoft.EntityFrameworkCore.Tools -Version 8.0.12

//=========================================================================================================================================
// 
4️ - تثبيت EF Core Identity مع Entity Framework Core

Install-Package Microsoft.AspNetCore.Identity.EntityFrameworkCore -Version 8.0.12 
    
//=========================================================================================================================================

5 - تفعيل خاصية التحميل الكسول (Lazy Loading)
🔹 Microsoft.EntityFrameworkCore.Proxies
تُستخدم هذه الحزمة لتفعيل خاصية Lazy Loading، التي تؤجل تحميل البيانات المرتبطة حتى يتم الوصول إليها :

Install-Package Microsoft.EntityFrameworkCore.Proxies -Version 8.0.12

//=========================================================================================================================================
//=========================================================================================================================================
//=========================================================================================================================================
//=========================================================================================================================================

🔹 التثبيت باستخدام ملف .csproj :

بدلاً من تثبيت كل حزمة يدويًا، يمكنك إضافتها مباشرةً إلى ملف .csproj الخاص بالمشروع.

انتقل إلى أي مشروع قديم لديك، وافتح ملف .csproj.
أضف الكود التالي بين وسوم <ItemGroup>:

<ItemGroup>
    <PackageReference Include="Microsoft.EntityFrameworkCore" Version="8.0.12" />
    <PackageReference Include="Microsoft.EntityFrameworkCore.Proxies" Version="8.0.12" />
    <PackageReference Include="Microsoft.EntityFrameworkCore.SqlServer" Version="8.0.12" />
    <PackageReference Include="Microsoft.EntityFrameworkCore.Tools" Version="8.0.12">
        <PrivateAssets>all</PrivateAssets>
        <IncludeAssets>runtime; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>
    </PackageReference>
</ItemGroup>


🔹 ملاحظة: إذا كنت بحاجة إلى تثبيت مكتبات أخرى، فما عليك سوى تغيير أسماء الحزم داخل ملف .csproj وفقًا لمتطلبات مشروعك.


//=========================================================================================================================================
🔹 عرض قائمة الحزم المثبتة
بعد تثبيت الحزم، يمكنك التحقق من الحزم الموجودة في مشروعك باستخدام الأمر التالي:

//=========================================================================================================================================

أصبح لديك الآن Entity Framework Core مثبتًا في مشروعك! ✅
يمكنك الآن البدء في إنشاء DbContext وتعريف النماذج (Models) الخاصة بك لبدء العمل مع قاعدة البيانات.
