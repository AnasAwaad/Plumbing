namespace CoreLayer.BaseEntities;
public class BaseEntity
{
    public int Id { get; set; }
    public DateTime CreatedDate { get; set; }
	public DateTime? UpdatedDate { get; set; }
    public byte[] RowVersion { get; set; } = null!;
}
