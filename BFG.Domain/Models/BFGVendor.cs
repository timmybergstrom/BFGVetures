namespace BFG.Domain;

public class BFGVendor : AuditableEntity
{
    public Guid Id { get; set; }
    public string VendorName { get; set; } = string.Empty;
    public string Address1 { get; set; } = string.Empty;
    public string Address2 { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string State { get; set; } = string.Empty;
    public string ZipCode { get; set; } = string.Empty;
    public string PhoneNumberNormal { get; set; } = string.Empty;
    public string PhoneNumberEmergency { get; set; } = string.Empty;
    public bool IsPreferred { get; set; }
}