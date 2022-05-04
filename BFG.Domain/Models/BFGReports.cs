namespace BFG.Domain;

public class BFGReports : AuditableEntity
{
    public Guid Id { get; set; }
    public BFGOutlets Outlet { get; set; } = new();
    public BFGUsers Author { get; set; } = new();
    public string Notes { get; set; } = string.Empty;
    public string Weather { get; set; } = string.Empty;
    public int Covers { get; set; }
    public string Issues { get; set; } = string.Empty;
}