namespace BFG.Domain;

public class BFGUsers : AuditableEntity
{
    public Guid Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string PreferredName { get; set; } = string.Empty;
    public string PhoneNumberPrimary { get; set; } = string.Empty;
}