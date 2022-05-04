using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BFG.Domain;

public class BFGVendorConfiguration : IEntityTypeConfiguration<BFGVendor>
{
    public void Configure(EntityTypeBuilder<BFGVendor> builder)
    {
        builder.HasKey(v => v.Id)
            .HasName("PK_VendorId");

        builder.Property(v => v.Id)
            .IsRequired()
            .ValueGeneratedOnAdd();

        builder.Property(v => v.VendorName)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(v => v.PhoneNumberNormal)
            .IsRequired()
            .HasMaxLength(10);
    }
}
