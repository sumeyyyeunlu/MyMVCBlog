using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyMVCBlog.Models.Mapping
{
    public class WriterMap : EntityTypeConfiguration<Writer>
    {
        public WriterMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Surname)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Mail)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Nick)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Writer");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Surname).HasColumnName("Surname");
            this.Property(t => t.Mail).HasColumnName("Mail");
            this.Property(t => t.RecordDate).HasColumnName("RecordDate");
            this.Property(t => t.Nick).HasColumnName("Nick");
            this.Property(t => t.ImageID).HasColumnName("ImageID");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.writer1).HasColumnName("writer");

            // Relationships
            this.HasRequired(t => t.Image)
                .WithMany(t => t.Writers)
                .HasForeignKey(d => d.ImageID);

        }
    }
}
