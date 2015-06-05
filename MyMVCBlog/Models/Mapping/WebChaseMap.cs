using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyMVCBlog.Models.Mapping
{
    public class WebChaseMap : EntityTypeConfiguration<WebChase>
    {
        public WebChaseMap()
        {
            // Primary Key
            this.HasKey(t => t.Mail);

            // Properties
            this.Property(t => t.Mail)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("WebChase");
            this.Property(t => t.Mail).HasColumnName("Mail");
            this.Property(t => t.WriterID).HasColumnName("WriterID");
            this.Property(t => t.CategoryID).HasColumnName("CategoryID");

            // Relationships
            this.HasOptional(t => t.Category)
                .WithMany(t => t.WebChases)
                .HasForeignKey(d => d.CategoryID);
            this.HasOptional(t => t.Writer)
                .WithMany(t => t.WebChases)
                .HasForeignKey(d => d.WriterID);

        }
    }
}
