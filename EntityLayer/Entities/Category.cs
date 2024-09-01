using CoreLayer.BaseEntities;

namespace EntityLayer.Entities;
public class Category :BaseEntity
{
    public string Name { get; set; } = null!;

    public IEnumerable<Portfolio> Portfolios { get; set; } = new List<Portfolio>();
}
