مقدمة إلى Entity Framework
ما هو Entity Framework؟
Entity Framework (EF) هو إطار عمل ORM (Object-Relational Mapper) لمنصة .NET، يهدف إلى تسهيل التعامل مع قواعد البيانات من خلال العمل مع الكيانات (Objects) بدلًا من كتابة استعلامات SQL يدويًا. يساعد في إدارة عمليات الاستعلام، الإدراج، التحديث، والحذف بسهولة مع الحفاظ على تكامل البيانات.

لماذا نستخدم Entity Framework؟
✔ تقليل الأكواد المتكررة: يتيح العمل مع البيانات دون الحاجة إلى كتابة استعلامات SQL مباشرة.
✔ دعم أنظمة قواعد بيانات متعددة: مثل SQL Server، MySQL، PostgreSQL وغيرهم.
✔ دعم لنهجي Code-First و Database-First: مما يوفر مرونة في تصميم قاعدة البيانات.
✔ إدارة العلاقات بين البيانات: مثل العلاقات واحد-لواحد (1:1)، واحد-لعدة (1:M)، عدة-لعدة (M:M) بسهولة.
✔ تتبع التغييرات تلقائيًا: يقوم بتتبع التعديلات على البيانات وتحديثها بكفاءة.

أنواع النهج المستخدمة في Entity Framework
1- Code-First (التكويد أولًا)
يتم إنشاء قاعدة البيانات تلقائيًا بناءً على الكلاسات (C# Classes) التي يكتبها المطور.
مثال على تعريف كيان (Entity):

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
}

🔹 عند تشغيل التطبيق، سيتم إنشاء جدول Students في قاعدة البيانات بناءً على هذا الكود.

//===============================================================================================================================

2- Database-First (القاعدة أولًا)
يتم استخدامه عندما تكون قاعدة البيانات موجودة مسبقًا، حيث يقوم EF بإنشاء الكيانات تلقائيًا بناءً على الجداول في قاعدة البيانات.
3- Model-First (النموذج أولًا) (أقل شيوعًا اليوم)
يتم تصميم النموذج المرئي (ERD)، ثم يقوم EF بإنشاء كل من قاعدة البيانات والنماذج البرمجية (Classes) تلقائيًا.
خطوات العمل مع Entity Framework
1. تثبيت Entity Framework عبر NuGet
Install-Package Microsoft.EntityFrameworkCore.SqlServer


public class AppDbContext : DbContext
{
    public DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Your_Connection_String");
    }
}

🔹 هذا الكود يعرف جدول الطلاب (Students) ويحدد اتصال قاعدة البيانات.

//===============================================================================================================================

3. تنفيذ عمليات CRUD (إضافة، قراءة، تعديل، حذف)
✔ إضافة بيانات إلى الجدول:
using (var context = new AppDbContext())
{
    var student = new Student { Name = "أحمد" };
    context.Students.Add(student);
    context.SaveChanges();
}

✔ جلب جميع البيانات من الجدول:
var students = context.Students.ToList();


✔ تحديث بيانات طالب معين:

var student = context.Students.FirstOrDefault(s => s.Id == 1);
if (student != null)
{
    student.Name = "محمد";
    context.SaveChanges();
}

✔ حذف سجل من الجدول:

var student = context.Students.Find(1);
if (student != null)
{
    context.Students.Remove(student);
    context.SaveChanges();
}


يعد Entity Framework أداة قوية تساعد في إدارة قواعد البيانات بكفاءة داخل تطبيقات .NET، وتوفر خيارات مرنة لإنشاء الكيانات والعمل مع البيانات بسهولة دون الحاجة إلى كتابة استعلامات SQL معقدة.