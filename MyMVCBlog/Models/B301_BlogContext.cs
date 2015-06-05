using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using MyMVCBlog.Models.Mapping;

namespace MyMVCBlog.Models
{
    public partial class BlogContext : DbContext
    {
        static BlogContext()
        {
            Database.SetInitializer<BlogContext>(null);
        }

        public BlogContext()
            : base("Name=B301_BlogContext")
        {
        }

        public DbSet<Articlee> Articlees { get; set; }
        public DbSet<ArticleImage> ArticleImages { get; set; }
        public DbSet<ArticleType> ArticleTypes { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<VisitorIPLog> VisitorIPLogs { get; set; }
        public DbSet<WebChase> WebChases { get; set; }
        public DbSet<Writer> Writers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ArticleeMap());
            modelBuilder.Configurations.Add(new ArticleImageMap());
            modelBuilder.Configurations.Add(new ArticleTypeMap());
            modelBuilder.Configurations.Add(new CategoryMap());
            modelBuilder.Configurations.Add(new CommentMap());
            modelBuilder.Configurations.Add(new ImageMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new TagMap());
            modelBuilder.Configurations.Add(new VisitorIPLogMap());
            modelBuilder.Configurations.Add(new WebChaseMap());
            modelBuilder.Configurations.Add(new WriterMap());
        }
    }
}
