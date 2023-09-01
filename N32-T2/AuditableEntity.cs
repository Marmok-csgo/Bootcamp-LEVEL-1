namespace N32_T2;

public abstract class AuditableEntity
{
    public DateTime CreatedDate { get; set; }
    public DateTime ModifieldDate { get; set; }

    protected AuditableEntity(DateTime createdDate, DateTime modifieldDate)
    {
        CreatedDate = createdDate;
        ModifieldDate = modifieldDate;
    }
}