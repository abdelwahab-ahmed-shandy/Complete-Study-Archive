/// One To One :

// شرح علاقة One To One في قواعد البيانات
// علاقة One to One (واحد إلى واحد) هي نوع من العلاقات بين الجداول في قاعدة البيانات،
// حيث يكون لكل سجل في الجدول الأول ارتباط بسجل واحد فقط في الجدول الثاني، والعكس صحيح.

//=================================================================================================================================

// 📌 مثال عملي

// السيناريو:
// لنفترض أن لدينا قاعدة بيانات لمكتبة، ولدينا جدولين:
// جدول "المؤلفين" (Authors): يحتوي على معلومات عن المؤلفين.
// جدول "السير الذاتية" (AuthorDetails): يحتوي على معلومات تفصيلية عن المؤلفين.

// القاعدة:
// كل مؤلف لديه سيرة ذاتية واحدة فقط.
// وكل سيرة ذاتية مرتبطة بمؤلف واحد فقط.
// هذا يعني أن العلاقة بين Authors و AuthorDetails هي One to One.

//=================================================================================================================================

// كيفية تمثيل العلاقة في قاعدة البيانات؟
// باستخدام المفاتيح الأساسية (Primary Key) والمفتاح الخارجي (Foreign Key)

// One :
public class Author
{
    public int AuthorID { get; set; }  // مفتاح أساسي
    public string Name { get; set; }
    public AuthorDetails AuthorDetails { get; set; } // علاقة One-To-One
}

// One :
public class AuthorDetails
{
    public int AuthorDetailsID { get; set; }  // مفتاح أساسي
    public string Biography { get; set; }
    public int AuthorID { get; set; }  // مفتاح خارجي يربط السيرة الذاتية بالمؤلف
    public Author Author { get; set; } // خصيصة التنقل
}

//=================================================================================================================================

// تكوين العلاقة باستخدام Fluent API:

public class LibraryContext : DbContext
{
    public DbSet<Author> Authors { get; set; }
    public DbSet<AuthorDetails> AuthorDetails { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.;Database=LibraryDB;Trusted_Connection=True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Author>()
            .HasOne(a => a.AuthorDetails)  // لكل مؤلف سيرة ذاتية واحدة
            .WithOne(ad => ad.Author) // لكل سيرة ذاتية مؤلف واحد
            .HasForeignKey<AuthorDetails>(ad => ad.AuthorID); // المفتاح الخارجي
    }
}

//=================================================================================================================================

// إدخال بيانات واختبار العلاقة:
using (var context = new LibraryContext())
{
    var author = new Author { Name = "نجيب محفوظ" };
    var authorDetails = new AuthorDetails { Biography = "أحد أهم الأدباء العرب", Author = author };

    context.Authors.Add(author);
    context.AuthorDetails.Add(authorDetails);
    context.SaveChanges();
}

//=================================================================================================================================

// جلب البيانات باستخدام Include:
using (var context = new LibraryContext())
{
    var authorsWithDetails = context.Authors.Include(a => a.AuthorDetails).ToList();

    foreach (var author in authorsWithDetails)
    {
        Console.WriteLine($"✍️ المؤلف: {author.Name}");
        Console.WriteLine($"   📖 السيرة الذاتية: {author.AuthorDetails.Biography}");
    }
}
