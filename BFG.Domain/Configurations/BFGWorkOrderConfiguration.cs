using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BFG.Domain;

public class BFGWorkOrderConfiguration : IEntityTypeConfiguration<BFGWorkOrders>
{
    public void Configure(EntityTypeBuilder<BFGWorkOrders> builder)
    {
        builder.HasKey(w => w.Id)
        .HasName("PK_WorkOrders");

        builder.Property(w => w.Id)
            .IsRequired()
            .ValueGeneratedOnAdd();

        builder.Property(w => w.Equipment)
            .IsRequired();

        builder.Property(w => w.WorkNeeded)
            .IsRequired()
            .HasMaxLength(4000);

        builder.Property(w => w.WorkNotes)
            .HasMaxLength(4000);

        builder.Property(w => w.IsClosed)
            .HasDefaultValue(false);

        builder.Property(w => w.IsActive)
            .HasDefaultValue(true);
    }
}
