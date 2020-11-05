using System.Data.Entity;

namespace EducationMvc.Models
{
    public class BookContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public BookContext() : base(nameOrConnectionString: "Default") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            modelBuilder.Entity<Book>().ToTable("book", "public");
            modelBuilder.Entity<Purchase>().ToTable("purchase", "public");
            base.OnModelCreating(modelBuilder);
        }
    }
}