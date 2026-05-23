using Microsoft.EntityFrameworkCore;

namespace SeyahatRehberim_demo.Models.Classes
{
    public class Context : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // appsettings.json içindeki bağlantı dizesini buraya yapıştırıyoruz
            optionsBuilder.UseSqlServer("Server=DESKTOP-VEMFHFH\\SQLEXPRESS;Database=SeyahatRehberimDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
