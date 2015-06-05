using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyMVCBlog.Models.Mapping
{
    public class ArticleImageMap : EntityTypeConfiguration<ArticleImage>
    {
        public ArticleImageMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ArticleID, t.ImageID });

            // Properties
            this.Property(t => t.ArticleID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ImageID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ArticleImages");
            this.Property(t => t.ArticleID).HasColumnName("ArticleID");
            this.Property(t => t.ImageID).HasColumnName("ImageID");

            // Relationships
            this.HasRequired(t => t.Articlee)
                .WithMany(t => t.ArticleImages)
                .HasForeignKey(d => d.ArticleID);
            this.HasRequired(t => t.Articlee1)
                .WithMany(t => t.ArticleImages1)
                .HasForeignKey(d => d.ArticleID);
            this.HasRequired(t => t.Image)
                .WithMany(t => t.ArticleImages)
                .HasForeignKey(d => d.ImageID);
            this.HasRequired(t => t.Image1)
                .WithMany(t => t.ArticleImages1)
                .HasForeignKey(d => d.ImageID);

        }
    }
}
