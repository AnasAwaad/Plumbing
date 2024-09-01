﻿using CoreLayer.BaseEntities;

namespace EntityLayer.Entities;
public class Team : BaseEntity
{
	public string FullName { get; set; } = null!;
	public string Title { get; set; } = null!;
	public string FileName { get; set; } = null!;
	public string FileType { get; set; } = null!;
	public string? Twitter { get; set; } = null!;
	public string? LinkedIn { get; set; } = null!;
	public string? Facebook { get; set; } = null!;
	public string? Instagram { get; set; } = null!;
}
