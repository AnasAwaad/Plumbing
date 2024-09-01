using EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RepositoryLayer.Configurations;
public class HomePageConfig : IEntityTypeConfiguration<HomePage>
{
	public void Configure(EntityTypeBuilder<HomePage> builder)
	{
		builder.Property(e => e.CreatedDate).IsRequired().HasMaxLength(10);//  30/12/2024
		builder.Property(e => e.UpdatedDate).HasMaxLength(10);
		builder.Property(e => e.RowVersion).IsRowVersion();
		builder.Property(e=>e.Header).IsRequired().HasMaxLength(200);
		builder.Property(e=>e.Description).IsRequired().HasMaxLength(2000);
		builder.Property(e => e.VideoLink).IsRequired();
	}
}
