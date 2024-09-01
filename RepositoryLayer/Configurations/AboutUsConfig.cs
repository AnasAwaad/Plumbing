using EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RepositoryLayer.Configurations;
public class AboutUsConfig : IEntityTypeConfiguration<AboutUs>
{
	public void Configure(EntityTypeBuilder<AboutUs> builder)
	{
		builder.Property(e => e.CreatedDate).IsRequired().HasMaxLength(10);//  30/12/2024
		builder.Property(e => e.UpdatedDate).HasMaxLength(10);
		builder.Property(e => e.RowVersion).IsRowVersion();
		builder.Property(e => e.Header).IsRequired().HasMaxLength(200);
		builder.Property(e => e.Description).IsRequired().HasMaxLength(5000);
		builder.Property(e => e.Clients).IsRequired().HasMaxLength(5);
		builder.Property(e => e.Projects).IsRequired().HasMaxLength(5);
		builder.Property(e => e.HoursOfSupport).IsRequired().HasMaxLength(5);
		builder.Property(e => e.Description).IsRequired().HasMaxLength(5);
		
	}
}
