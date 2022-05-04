namespace BFG.Domain;

public class BFGEquipment : AuditableEntity
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string SerialNumber { get; set; } = string.Empty;
    public int Location { get; set; }
    public bool IsMissionCritical { get; set; } 
    public DateOnly InServiceDt { get; set; }
    public int ExpectedYrsInService { get; set; }
    public DateOnly OutOfServiceDt { get; set; }
}