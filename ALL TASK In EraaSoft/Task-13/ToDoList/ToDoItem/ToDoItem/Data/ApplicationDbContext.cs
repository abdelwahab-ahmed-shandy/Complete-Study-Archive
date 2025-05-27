namespace ToDoItem.Data
{
    public class ApplicationDbContext : DbContext
    {
        #region Table In DataBase
        public DbSet<Models.ToDoList> toDoLists { get; set; }
        #endregion


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            #region Connection In DataBase
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=todoitem-Db;Integrated Security=True;TrustServerCertificate=True");
            #endregion
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region Seed Data In Data Base
            modelBuilder.Entity<ToDoList>().HasData(
            new ToDoList { Id = 1, Title = "Learn C#", Description = "Practice basic and advanced C# concepts", DeadLine = DateTime.Now.AddDays(7) },
            new ToDoList { Id = 2, Title = "Build ASP.NET App", Description = "Create a To-Do List web app using ASP.NET Core", DeadLine = DateTime.Now.AddDays(14) },
            new ToDoList { Id = 3, Title = "Database Integration", Description = "Connect the To-Do List app with a SQL database", DeadLine = DateTime.Now.AddDays(21) }
        );
            #endregion

        }
    }
}
