using System.Data.Entity;
using TeduShop.Model.Models;

namespace TeduShop.Data
{
    public class TeduShopDbContext : DbContext
    {
        public TeduShopDbContext() : base("TeduShopConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
            //cấu hình load bảng cha không cần load bản con

        }
        public DbSet<Footer> Footers {get;set;}
        public DbSet<Footer> Menus { get; set; }
        public DbSet<Footer> MenuGroups { get; set; }
        public DbSet<Footer> Orders { get; set; }
        public DbSet<Footer> OrderDetail { get; set; }
        public DbSet<Footer> Pages { get; set; }
        public DbSet<Footer> Posts { get; set; }
        public DbSet<Footer> PostCategories { get; set; }
        public DbSet<Footer> PostTags { get; set; }
        public DbSet<Footer> Products { get; set; }
        public DbSet<Footer> ProductCategories { get; set; }
        public DbSet<Footer> ProductTags { get; set; }
        public DbSet<Footer> Slides { get; set; }
        public DbSet<Footer> SupportOnlines { get; set; }
        public DbSet<Footer> SystemConfigs { get; set; }
        public DbSet<Footer> Tags { get; set; }
        public DbSet<Footer> VisitorStatistics { get; set; }
        protected override void OnModelCreating(DbModelBuilder builder)
        {

        }
    }
}