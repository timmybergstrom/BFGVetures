using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace BFG.Domain;

public class BFGdbContext : DbContext
{
    public BFGdbContext(DbContextOptions<BFGdbContext> options) : base(options)
    {
    }

    public DbSet<BFGEquipment>? Equipment { get; set; }
    public DbSet<BFGOutlets>? Outlets { get; set; }
    public DbSet<BFGReports>? Reports { get; set; }
    public DbSet<BFGUsers>? Users { get; set; }
    public DbSet<BFGWorkOrders>? WorkOrders { get; set; }
    public DbSet<BFGVendor>? Vendors { get; set; }
    
    public DbSet<BFGRoles>? UserRoles { get; set; }
    
    public DbSet<UserOutletRelationship>? UserOutlets { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        int i = 1;
        Guid g = new();

        builder.ApplyConfigurationsFromAssembly(typeof(BFGdbContext).Assembly);

        builder.Entity<BFGOutlets>().HasData(new BFGOutlets
        {
            Id = g,
            Name = "Hatties Downtown",
            Address1 = "49 Phila St",
            City = "Saratoga Springs",
            State = "NY",
            ZipCode = "12866",
            PhoneNumberPrimary = "5180000000",
            PublicWebSite = "https://www.hatties.com"
        });
        builder.Entity<BFGOutlets>().HasData(new BFGOutlets
        {
            Id = g,
            Name = "Hatties Wilton",
            Address1 = "Rt 50",
            Address2 = "Protein Plaza",
            City = "Wilton",
            State = "NY",
            ZipCode = "12000",
            PhoneNumberPrimary = "5180000000",
            PublicWebSite = "https://www.hattiesWilton.com"
        });
        builder.Entity<BFGOutlets>().HasData(new BFGOutlets
        {
            Id = g,
            Name = "Hatties Albany",
            Address1 = "Madison Ave",
            City = "Albany",
            State = "NY",
            ZipCode = "12207",
            PhoneNumberPrimary = "5180000000",
            PublicWebSite = "https://www.hattiesAlbany.com"
        });
        builder.Entity<BFGOutlets>().HasData(new BFGOutlets
        {
            Id = g,
            Name = "Bread Basket",
            Address1 = "Spring Street",
            City = "Saratoga Springs",
            State = "NY",
            ZipCode = "12866",
            PhoneNumberPrimary = "5180000000",
            PublicWebSite = "https://www.breadbasket.com"
        });
        builder.Entity<BFGOutlets>().HasData(new BFGOutlets
        {
            Id = g,
            Name = "Bread Basket West",
            Address1 = "West Ave",
            City = "Saratoga Springs",
            State = "NY",
            ZipCode = "12866",
            PhoneNumberPrimary = "5180000000",
            PublicWebSite = "https://www.breadbasketwest.com"
        });

        i = 1;
        builder.Entity<BFGRoles>().HasData(new BFGRoles
        {
            Id = 1,
            Description = "Server"
        });
        builder.Entity<BFGRoles>().HasData(new BFGRoles
        {
            Id = 2,
            Description = "Bartender"
        });
        builder.Entity<BFGRoles>().HasData(new BFGRoles
        {
            Id = 5,
            Description = "Runner"
        });
        builder.Entity<BFGRoles>().HasData(new BFGRoles
        {
            Id = 6,
            Description = "Busser"
        });
        builder.Entity<BFGRoles>().HasData(new BFGRoles
        {
            Id = 7,
            Description = "Host"
        });
        builder.Entity<BFGRoles>().HasData(new BFGRoles
        {
            Id = 10,
            Description = "Catering Server"
        });
        builder.Entity<BFGRoles>().HasData(new BFGRoles
        {
            Id = 20,
            Description = "Cook"
        });
        builder.Entity<BFGRoles>().HasData(new BFGRoles
        {
            Id = 30,
            Description = "Cleaner"
        });
        builder.Entity<BFGRoles>().HasData(new BFGRoles
        {
            Id = 21,
            Description = "Kitchen Manager/Chef"
        });
        builder.Entity<BFGRoles>().HasData(new BFGRoles
        {
            Id = 25,
            Description = "Catering Chef"
        });
        builder.Entity<BFGRoles>().HasData(new BFGRoles
        {
            Id = 50,
            Description = "Manager"
        });
        builder.Entity<BFGRoles>().HasData(new BFGRoles
        {
            Id = 51,
            Description = "Assistant Manager"
        });
        builder.Entity<BFGRoles>().HasData(new BFGRoles
        {
            Id = i++,
            Description = "Bar Manager"
        });
        builder.Entity<BFGRoles>().HasData(new BFGRoles
        {
            Id = 60,
            Description = "Restaurant Manager"
        });
        builder.Entity<BFGRoles>().HasData(new BFGRoles
        {
            Id = 70,
            Description = "Bookkeeper"
        });
        builder.Entity<BFGRoles>().HasData(new BFGRoles
        {
            Id = 90,
            Description = "Corporate Oversight"
        });
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
    {
        foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
        {
            switch (entry.State)
            {
                case EntityState.Added:
                    entry.Entity.CreatedDt = DateTime.Now;
                    break;
                case EntityState.Modified:
                    entry.Entity.ModifiedDt = DateTime.Now;
                    break;
            }
        }
        return base.SaveChangesAsync(cancellationToken);
    }
}