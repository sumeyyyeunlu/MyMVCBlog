using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyMVCBlog.Models.Mapping
{
    public class ImageMap : EntityTypeConfiguration<Image>
    {
        public ImageMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.SmallImageWay)
                .HasMaxLength(500);

            this.Property(t => t.MideumImageWay)
                .HasMaxLength(500);

            this.Property(t => t.BigImageWay)
                .HasMaxLength(500);

            this.Property(t => t.VideoWay)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Images");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.SmallImageWay).HasColumnName("SmallImageWay");
            this.Property(t => t.MideumImageWay).HasColumnName("MideumImageWay");
            this.Property(t => t.BigImageWay).HasColumnName("BigImageWay");
            this.Property(t => t.VideoWay).HasColumnName("VideoWay");
            this.Property(t => t.AddedID).HasColumnName("AddedID");
            this.Property(t => t.AddedTime).HasColumnName("AddedTime");
            this.Property(t => t.SeenTimes).HasColumnName("SeenTimes");
            this.Property(t => t.Like).HasColumnName("Like");

            // Relationships
            this.HasRequired(t => t.Writer)
                .WithMany(t => t.Images)
                .HasForeignKey(d => d.AddedID);

        }
    }
}
