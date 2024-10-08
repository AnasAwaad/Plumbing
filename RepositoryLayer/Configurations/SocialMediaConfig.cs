﻿using EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RepositoryLayer.Configurations;
public class SocialMediaConfig : IEntityTypeConfiguration<SocialMedia>
{
	public void Configure(EntityTypeBuilder<SocialMedia> builder)
	{
		builder.Property(e => e.CreatedDate).IsRequired().HasMaxLength(10);//  30/12/2024
		builder.Property(e => e.UpdatedDate).HasMaxLength(10);
		builder.Property(e => e.RowVersion).IsRowVersion();

		builder.HasData(new SocialMedia
		{
			Id = 1,
			Twitter = "test twitter",
			Instagram = "test instagram",
			Facebook = "test facebook",
			LinkedIn = "test linkedin",
		});
	}
}
