namespace BFG.Domain;

public class BFGWorkOrders : AuditableEntity
{
    public Guid Id { get; set; }
    public BFGEquipment Equipment { get; set; } = new();
    public string WorkNeeded { get; set; } = string.Empty;
    public string WorkNotes { get; set; } = string.Empty;
    public BFGVendor VendorSelected { get; set; } = new();
    public bool IsClosed { get; set; }
    public float ServiceCost { get; set; }
}