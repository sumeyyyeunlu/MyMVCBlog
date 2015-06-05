using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyMVCBlog.Models.Mapping
{
    public class CommentMap : EntityTypeConfiguration<Comment>
    {
        public CommentMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Title)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.Content)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("Comment");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Content).HasColumnName("Content");
            this.Property(t => t.ArticleID).HasColumnName("ArticleID");
            this.Property(t => t.AddedDate).HasColumnName("AddedDate");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.WriterID).HasColumnName("WriterID");

            // Relationships
            this.HasRequired(t => t.Articlee)
                .WithMany(t => t.Comments)
                .HasForeignKey(d => d.ArticleID);
            this.HasOptional(t => t.Writer)
                .WithMany(t => t.Comments)
                .HasForeignKey(d => d.WriterID);
            this.HasOptional(t => t.Writer1)
                .WithMany(t => t.Comments1)
                .HasForeignKey(d => d.WriterID);

        }
    }
}
