﻿using EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RepositoryLayer.Configurations;
public class ServiceConfig : IEntityTypeConfiguration<Service>
{
	public void Configure(EntityTypeBuilder<Service> builder)
	{
		builder.Property(e => e.CreatedDate).IsRequired().HasMaxLength(10);//  30/12/2024
		builder.Property(e => e.UpdatedDate).HasMaxLength(10);
		builder.Property(e => e.RowVersion).IsRowVersion();
		builder.Property(e => e.Name).IsRequired().HasMaxLength(200);
		builder.Property(e => e.Description).IsRequired().HasMaxLength(2000);
		builder.Property(e => e.Icon).IsRequired().HasMaxLength(100);

		builder.HasData(new Service
		{
			Id = 1,
			Name = "Name",
			Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
			Icon = "test icon",
		});
	}
}
