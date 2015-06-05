using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyMVCBlog.Models.Mapping
{
    public class ArticleeMap : EntityTypeConfiguration<Articlee>
    {
        public ArticleeMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.Content)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("Articlee");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Content).HasColumnName("Content");
            this.Property(t => t.DateTime).HasColumnName("DateTime");
            this.Property(t => t.CategoryID).HasColumnName("CategoryID");
            this.Property(t => t.ArticleTypeID).HasColumnName("ArticleTypeID");
            this.Property(t => t.WriterID).HasColumnName("WriterID");
            this.Property(t => t.ImageID).HasColumnName("ImageID");
            this.Property(t => t.Like).HasColumnName("Like");
            this.Property(t => t.SeenTimes).HasColumnName("SeenTimes");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasMany(t => t.Tags)
                .WithMany(t => t.Articlees)
                .Map(m =>
                    {
                        m.ToTable("ArticleTag");
                        m.MapLeftKey("ArticleID");
                        m.MapRightKey("TagID");
                    });

            this.HasRequired(t => t.ArticleType)
                .WithMany(t => t.Articlees)
                .HasForeignKey(d => d.ArticleTypeID);
            this.HasRequired(t => t.Category)
                .WithMany(t => t.Articlees)
                .HasForeignKey(d => d.CategoryID);
            this.HasRequired(t => t.Image)
                .WithMany(t => t.Articlees)
                .HasForeignKey(d => d.ImageID);
            this.HasRequired(t => t.Writer)
                .WithMany(t => t.Articlees)
                .HasForeignKey(d => d.WriterID);
            this.HasRequired(t => t.Writer1)
                .WithMany(t => t.Articlees1)
                .HasForeignKey(d => d.WriterID);

        }
    }
}
