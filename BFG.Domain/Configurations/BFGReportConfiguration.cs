using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BFG.Domain;

public class BFGReportConfiguration : IEntityTypeConfiguration<BFGReports>
{
    public void Configure(EntityTypeBuilder<BFGReports> builder)
    {
        builder.HasKey(g => g.Id)
        .HasName("PK_Reports");

        builder.Property(g => g.Id)
        .IsRequired()
        .ValueGeneratedOnAdd();

        builder.Property(g => g.CreatedBy)
        .IsRequired();

        builder.HasOne(g => g.Author);

        builder.HasOne(g => g.Outlet);
    }
}
