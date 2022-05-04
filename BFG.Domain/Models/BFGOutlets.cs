namespace BFG.Domain;

public class BFGOutlets : AuditableEntity
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Address1 { get; set; } = string.Empty;
    public string? Address2 { get; set; }
    public string City { get; set; } = string.Empty;
    public string State { get; set; } = string.Empty;
    public string ZipCode { get; set; } = string.Empty;
    public string PhoneNumberPrimary { get; set; } = string.Empty;
    public string PhoneNumberSecondary { get; set; } = String.Empty;
    public string PublicWebSite { get; set; } = String.Empty;
}