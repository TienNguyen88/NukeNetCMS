using NukeNetCMS.Model.Models;
using System.Data.Entity;

namespace NukeNetCMS.Data
{
    public class NukeNetCmsDbContext : DbContext
    {
        public NukeNetCmsDbContext() : base("NukeNetCmsConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Advertising> Advertisings { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ContactField> ContactFields { get; set; }
        public DbSet<Control> Controls { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Coupon> Coupons { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<MenuDetail> MenuDetails { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<PageComment> PageComments { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<PaymentTransaction> PaymentTransactions { get; set; }
        public DbSet<Plugin> Plugins { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostCategory> PostCategories { get; set; }
        public DbSet<PostComment> PostComments { get; set; }
        public DbSet<PostTag> PostTags { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductComment> ProductComments { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<ProductTag> ProductTags { get; set; }
        public DbSet<Shipping> Shippings { get; set; }
        public DbSet<ShippingMethod> ShippingMethods { get; set; }
        public DbSet<Slide> Slides { get; set; }
        public DbSet<SupportOnline> SupportOnlines { get; set; }
        public DbSet<SystemConfig> SystemConfigs { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Template> Templates { get; set; }
        public DbSet<VisitorStatistic> VisitorStatistics { get; set; }
        public DbSet<Widget> Widgets { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}