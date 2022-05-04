namespace BFG.Domain;

public class UserOutletRelationship : AuditableEntity
{
    public int Id { get; set; }
    public BFGUsers User { get; set; } = new();
    public BFGOutlets Outlet { get; set; } = new();
    public BFGRoles Role { get; set; } = new();
}