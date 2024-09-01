using EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RepositoryLayer.Configurations;
public class ContactUsConfig : IEntityTypeConfiguration<ContactUs>
{
	public void Configure(EntityTypeBuilder<ContactUs> builder)
	{
		builder.Property(e => e.CreatedDate).IsRequired().HasMaxLength(10);//  30/12/2024
		builder.Property(e => e.UpdatedDate).HasMaxLength(10);
		builder.Property(e => e.RowVersion).IsRowVersion();
		builder.Property(e=>e.Location).IsRequired().HasMaxLength(200);
		builder.Property(e=>e.Email).IsRequired().HasMaxLength(100);
		builder.Property(e=>e.Call).IsRequired().HasMaxLength(13);
		builder.Property(e=>e.Map).IsRequired();

		builder.HasData(new ContactUs
		{
			Id = 1,
			Location = "egypt, giza , 6-october",
			Call = "01129426838",
			Email = "anas.shaban.awaad@gmail.com",
			Map = "test map",
		});
	}
}
