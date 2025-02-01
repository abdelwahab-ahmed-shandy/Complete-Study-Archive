// عليك الان انشاء فولدر تحت مسمى  Data or Data Access 
// Now you have to create a folder called Data or Data Access:


// We will create a class inside it called :  ApplicationDbContext


protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=EFTest510;Integrated Security=True;TrustServerCertificate=True");
        }


// This part calls the base method from which it inherits :

base.OnConfiguring(optionsBuilder);

// You can say that this part is the page that you log in to when you enter the server :
// This section explains how to connect to the database on the server.
// داخل ال optionsBuilder.UseSqlServer :
// في داخل ملف ال DbContext :

optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=EFTest510;Integrated Security=True;TrustServerCertificate=True");


// Each connection changes depending on the database (Initial Catalog) name and server name (Data Source).

