using EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RepositoryLayer.Configurations;
public class TestimonialConfig : IEntityTypeConfiguration<Testimonial>
{
	public void Configure(EntityTypeBuilder<Testimonial> builder)
	{
		builder.Property(e => e.CreatedDate).IsRequired().HasMaxLength(10);//  30/12/2024
		builder.Property(e => e.UpdatedDate).HasMaxLength(10);
		builder.Property(e => e.RowVersion).IsRowVersion();

		builder.Property(e => e.FullName).IsRequired().HasMaxLength(100);
		builder.Property(e => e.Title).IsRequired().HasMaxLength(100);
		builder.Property(e => e.Comment).IsRequired().HasMaxLength(200);
		builder.Property(e => e.FileType).IsRequired();
		builder.Property(e => e.FileName).IsRequired();

	}
}
