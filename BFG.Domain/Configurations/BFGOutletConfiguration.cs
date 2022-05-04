using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BFG.Domain;

public class BFGOutletsConfiguration : IEntityTypeConfiguration<BFGOutlets>
{
    public void  Configure(EntityTypeBuilder<BFGOutlets> builder)
    {
        builder.HasKey(o => o.Id)
        .HasName("PK_Outlets"); 
        
        builder.Property(o => o.Id)
            .ValueGeneratedOnAdd();   

        builder.Property(o => o.Name)
            .IsRequired()
            .HasMaxLength(150);

        builder.Property(o => o.Address1)
            .IsRequired()
            .HasMaxLength(150);

        builder.Property(o => o.Address2)
            .HasMaxLength(150);

        builder.Property(o => o.City)
            .IsRequired()
            .HasMaxLength(100);      

        builder.Property(o => o.State)
            .IsRequired()
            .HasMaxLength(2)
            .HasDefaultValue("NY");   

        builder.Property(o => o.PhoneNumberPrimary)
            .IsRequired()
            .HasMaxLength(10);          

        builder.Property(o => o.IsActive)
            .HasDefaultValue(true);    
    }
}