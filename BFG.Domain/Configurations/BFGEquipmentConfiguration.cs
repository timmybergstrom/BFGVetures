using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BFG.Domain;

public class BFGEquipmentConfiguration : IEntityTypeConfiguration<BFGEquipment>
{
    public void Configure(EntityTypeBuilder<BFGEquipment> builder)
    {
        builder.HasKey(o =>o.Id)
            .HasName("PK_Equipment");

        builder.Property(o => o.Id)
            .ValueGeneratedOnAdd();
    }
}