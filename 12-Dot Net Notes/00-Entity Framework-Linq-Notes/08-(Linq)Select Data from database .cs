/*
✅ استعلام البيانات باستخدام LINQ في Entity Framework Core
بعد إنشاء DbContext وربطه بقاعدة البيانات، يمكنك استخدام LINQ لاسترجاع البيانات بطرق مختلفة. إليك مجموعة من الطرق مع الأمثلة العملية:

*/



using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace LINQ_EntityFramework
{
    public class Author
    {
        public int AuthorID { get; set; }
        public string Name { get; set; }
        public string Nationality { get; set; }
        public List<Book> Books { get; set; }
    }

    public class Book
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public int AuthorID { get; set; }
        public Author Author { get; set; }
    }

    public class LibraryContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("your_connection_string_here");
        }
    }

    class Program
    {
        static void Main()
        {
            using (var context = new LibraryContext())
            {
                // 1. استرجاع جميع المؤلفين من قاعدة البيانات
				
				// 📌 ToList() → يجلب جميع البيانات من الجدول.
				
                var authors = context.Authors.ToList();
                Console.WriteLine("📚 قائمة المؤلفين:");
                foreach (var author in authors)
                {
                    Console.WriteLine($"✍️ {author.Name}");
                }

                // 2. تصفية المؤلفين حسب الجنسية باستخدام Where
				
				// 📌 Where(condition) → لجلب بيانات محددة بناءً على شرط معين.
				
                var egyptianAuthors = context.Authors
                    .Where(a => a.Nationality == "Egyptian")
                    .ToList();
                Console.WriteLine("\n📚 المؤلفون المصريون:");
                foreach (var author in egyptianAuthors)
                {
                    Console.WriteLine($"✍️ {author.Name}");
                }

                // 3. البحث عن مؤلف حسب معرفه باستخدام Find
				
				// 📌 Find(id) → يستخدم المفتاح الأساسي لاسترجاع البيانات.
				
                var authorById = context.Authors.Find(1);
                Console.WriteLine("\n🔎 البحث عن مؤلف بمعرف معين:");
                Console.WriteLine(authorById != null ? $"✅ المؤلف: {authorById.Name}" : "❌ لم يتم العثور على المؤلف");

                // 4. البحث عن أول كتاب بعنوان معين
				
				// 📌 FirstOrDefault() → يُرجع أول سجل يطابق الشرط، أو null إن لم يوجد.
				
                var book = context.Books.FirstOrDefault(b => b.Title == "اللص والكلاب");
                Console.WriteLine("\n🔎 البحث عن كتاب بعنوان معين:");
                Console.WriteLine(book != null ? $"📖 العنوان: {book.Title}" : "❌ لم يتم العثور على الكتاب");

                
				// 5. جلب المؤلفين مع كتبهم باستخدام Include
				
				//📌 Include() → يجلب البيانات المرتبطة من جدول آخر لتجنب Lazy Loading.
				
                var authorsWithBooks = context.Authors.Include(a => a.Books).ToList();
                Console.WriteLine("\n📚 المؤلفون وكتبهم:");
                foreach (var author in authorsWithBooks)
                {
                    Console.WriteLine($"✍️ المؤلف: {author.Name}");
                    foreach (var bookItem in author.Books)
                    {
                        Console.WriteLine($"   📖 {bookItem.Title}");
                    }
                }

                // 6. ترتيب الكتب حسب العنوان
				/*
				📌 OrderBy(column) → ترتيب تصاعدي
				📌 OrderByDescending(column) → ترتيب تنازلي
				*/
				
                var sortedBooks = context.Books.OrderBy(b => b.Title).ToList();
                Console.WriteLine("\n📚 قائمة الكتب مرتبة أبجديًا:");
                foreach (var bookItem in sortedBooks)
                {
                    Console.WriteLine($"📖 {bookItem.Title}");
                }

                // 7. تحديد أعمدة محددة باستخدام Select
				
				// 📌 Select() → يسمح بتحديد حقول محددة فقط.
				
                var bookTitles = context.Books.Select(b => new { b.Title, b.BookID }).ToList();
                Console.WriteLine("\n📚 عناوين الكتب وأرقامها:");
                foreach (var bookItem in bookTitles)
                {
                    Console.WriteLine($"📖 {bookItem.BookID} - {bookItem.Title}");
                }

                // 8. التحقق من وجود كتب في المكتبة
				
				// 📌 Any() → يعيد true إذا كان هناك بيانات في الجدول.
				
                bool hasBooks = context.Books.Any();
                Console.WriteLine("\n📚 التحقق من وجود كتب:");
                Console.WriteLine(hasBooks ? "✅ يوجد كتب في المكتبة" : "❌ لا يوجد كتب");

                // 9. حساب عدد الكتب
				
				// 📌 Count() → لحساب عدد السجلات.
				
                int bookCount = context.Books.Count();
                Console.WriteLine($"\n📚 عدد الكتب في المكتبة: {bookCount}");

                // 10. إيجاد أعلى قيمة لمعرف الكتب
				
				// 📌 Max(column) → يجلب أكبر قيمة في العمود.
				
                int maxId = context.Books.Max(b => b.BookID);
                Console.WriteLine($"\n📌 أعلى ID للكتب: {maxId}");

                // 11. تقسيم النتائج (Pagination) باستخدام Skip و Take
				
				/*
				📌 Skip(n) → يتجاوز عدد معين من السجلات.
				📌 Take(n) → يجلب عدد معين من السجلات.
				*/
				
                var paginatedBooks = context.Books.OrderBy(b => b.BookID).Skip(5).Take(10).ToList();
                Console.WriteLine("\n📚 عرض جزء من قائمة الكتب:");
                foreach (var bookItem in paginatedBooks)
                {
                    Console.WriteLine($"📖 {bookItem.Title}");
                }

                // 12. تجميع الكتب حسب المؤلفين
				
				// 📌 GroupBy() → يجمع البيانات بناءً على قيمة معينة.
				
                var booksByAuthors = context.Books.GroupBy(b => b.AuthorID)
                    .Select(group => new { AuthorID = group.Key, BookCount = group.Count() })
                    .ToList();
                Console.WriteLine("\n📚 عدد الكتب لكل مؤلف:");
                foreach (var entry in booksByAuthors)
                {
                    Console.WriteLine($"🖊 المؤلف {entry.AuthorID} لديه {entry.BookCount} كتب");
                }
            }
        }
    }
}



/*
✅ 🎯 خلاصة
🔹 LINQ في Entity Framework Core يمنحك طرقًا قوية لاستعلام البيانات بكفاءة.
🔹 استخدم Include() عند الحاجة لجلب البيانات المرتبطة.
🔹 استخدم Where(), OrderBy(), و Select() لتصفية وترتيب البيانات.
🔹 استخدم Skip() و Take() للتقسيم والتحميل التدريجي.
*/