namespace BFG.Domain;

public class AuditableEntity
{
    public int CreatedBy { get; set; }
    public DateTime CreatedDt { get; set; }
    public int ModifiedBy { get; set; }
    public DateTime ModifiedDt { get; set; }
    public bool IsActive { get; set; }
}