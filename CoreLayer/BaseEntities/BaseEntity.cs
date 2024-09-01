namespace CoreLayer.BaseEntities;
public class BaseEntity:IBaseEntity
{
    public BaseEntity()
    {
        CreatedDate = DateTime.Now;
    }
    public int Id { get; set; }
    public DateTime CreatedDate { get; set; }
	public DateTime? UpdatedDate { get; set; }
    public byte[] RowVersion { get; set; } = null!;
}
