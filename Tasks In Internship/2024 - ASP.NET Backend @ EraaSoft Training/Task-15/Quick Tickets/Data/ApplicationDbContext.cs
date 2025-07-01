namespace Quick_Tickets.Data;

public partial class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Actor> Actors { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Cinema> Cinemas { get; set; }

    public virtual DbSet<Movie> Movies { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        #region Relations 


        modelBuilder.Entity<ActorMovie>()
       .HasKey(am => new { am.ActorId, am.MovieId });

        modelBuilder.Entity<Actor>(entity =>
        {
            entity.ToTable("actors");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.ToTable("categories");
        });

        modelBuilder.Entity<Cinema>(entity =>
        {
            entity.ToTable("cinemas");
        });

        modelBuilder.Entity<Movie>(entity =>
        {
            entity.ToTable("movies");

            entity.HasIndex(e => e.CategoryId, "IX_movies_CategoryId");

            entity.HasIndex(e => e.CinemaId, "IX_movies_CinemaId");

            entity.HasOne(d => d.Category).WithMany(p => p.Movies)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Cinema).WithMany(p => p.Movies)
                .HasForeignKey(d => d.CinemaId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasMany(d => d.Actors).WithMany(p => p.Movies)
                .UsingEntity<Dictionary<string, object>>(
                    "ActorMovie",
                    r => r.HasOne<Actor>().WithMany().HasForeignKey("ActorId"),
                    l => l.HasOne<Movie>().WithMany().HasForeignKey("MovieId"),
                    j =>
                    {
                        j.HasKey("MovieId", "ActorId");
                        j.ToTable("actorMovies");
                        j.HasIndex(new[] { "ActorId" }, "IX_actorMovies_ActorId");
                    });
        });
        #endregion

        #region Seed Data 

        // Add categories
        modelBuilder.Entity<Category>().HasData(
            new Category { Id = 1, Name = "Anime", Description = "Animated movies with Japanese style" },
            new Category { Id = 2, Name = "Action", Description = "High-intensity movies with fights and explosions" },
            new Category { Id = 3, Name = "Horror", Description = "Scary movies with supernatural and thrilling elements" }
                                                );

        // Add cinemas
        modelBuilder.Entity<Cinema>().HasData(
            new Cinema { Id = 1, Name = "Cinema Max", Description = "Best action movies", CinemaLogo = "cinema_max.png", Address = "Downtown", CinemaPhonto = "1.png" },
            new Cinema { Id = 2, Name = "Horror Hub", Description = "Scariest horror movies", CinemaLogo = "horror_hub.png", Address = "Main Street", CinemaPhonto = "2.png" },
            new Cinema { Id = 3, Name = "Anime World", Description = "Top anime movies", CinemaLogo = "anime_world.png", Address = "Tokyo Avenue", CinemaPhonto = "3.png" }
                                             );

        //Add movies
        modelBuilder.Entity<Movie>().HasData(
        new Movie { Id = 1, Name = "Naruto: The Last", Description = "A great anime movie", Price = 12.99, ImgUrl = "naruto.jpg", TrailerUrl = "trailer_naruto.mp4", StartDate = DateTime.Now, EndDate = DateTime.Now.AddMonths(1), MovieStatus = 1, CinemaId = 3, CategoryId = 1 },
            new Movie { Id = 2, Name = "John Wick", Description = "Best action-packed movie", Price = 15.99, ImgUrl = "johnwick.jpg", TrailerUrl = "trailer_johnwick.mp4", StartDate = DateTime.Now, EndDate = DateTime.Now.AddMonths(1), MovieStatus = 1, CinemaId = 1, CategoryId = 2 },
            new Movie { Id = 3, Name = "The Conjuring", Description = "A terrifying horror movie", Price = 10.99, ImgUrl = "conjuring.jpg", TrailerUrl = "trailer_conjuring.mp4", StartDate = DateTime.Now, EndDate = DateTime.Now.AddMonths(1), MovieStatus = 1, CinemaId = 2, CategoryId = 3 }
                                            );
        // Add actors
        modelBuilder.Entity<Actor>().HasData(
            new Actor { Id = 1, FirstName = "Naruto", LastName = "Uzumaki", Bio = "Main character in Naruto", ProfilePicture = "naruto.png", News = "Became Hokage" },
            new Actor { Id = 2, FirstName = "Goku", LastName = "Son", Bio = "Main character in Dragon Ball", ProfilePicture = "goku.png", News = "Defeated Jiren" },
            new Actor { Id = 3, FirstName = "Keanu", LastName = "Reeves", Bio = "Hollywood action star", ProfilePicture = "keanu.png", News = "John Wick star" },
            new Actor { Id = 4, FirstName = "Vera", LastName = "Farmiga", Bio = "Horror actress", ProfilePicture = "vera.png", News = "The Conjuring series star" }
                                            );

        // Linking actors to movies
        modelBuilder.Entity<ActorMovie>().HasData(
            new ActorMovie { ActorId = 1, MovieId = 1 },
            new ActorMovie { ActorId = 2, MovieId = 1 },
            new ActorMovie { ActorId = 3, MovieId = 2 },
            new ActorMovie { ActorId = 4, MovieId = 3 }
                                                    );

        #endregion


        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
