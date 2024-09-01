using CoreLayer.BaseEntities;

namespace EntityLayer.Entities;
public class SocialMedia :BaseEntity
{
	public string? Twitter { get; set; } = null!;
	public string? LinkedIn { get; set; } = null!;
	public string? Facebook { get; set; } = null!;
	public string? Instagram { get; set; } = null!;

	public AboutUs AboutUs { get; set; } = null!;
}
