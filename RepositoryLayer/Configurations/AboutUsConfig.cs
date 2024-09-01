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
		builder.Property(e => e.HardWorkers).IsRequired().HasMaxLength(5);
		builder.Property(e => e.HoursOfSupport).IsRequired().HasMaxLength(500);

		builder.HasData(new AboutUs
		{
			Id = 1,
			Header = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ",
			Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
			Clients = 5,
			Projects = 5,
			HoursOfSupport = 120,
			HardWorkers = 5,
			FileName = "test",
			FileType = "test",
			SocialMediaId = 1
		});
	}
}
