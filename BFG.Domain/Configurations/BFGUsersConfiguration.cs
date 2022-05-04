using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BFG.Domain;

public class BFGUsersConfiguration : IEntityTypeConfiguration<BFGUsers>
{
    public void  Configure(EntityTypeBuilder<BFGUsers> builder)
    {
        builder.HasKey(a => a.Id)
            .HasName("PK_Users");

        builder.Property(a => a.Id)
            .ValueGeneratedOnAdd();

        builder.Property(a => a.FirstName)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(a => a.LastName)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(a => a.PreferredName)
            .HasMaxLength(100);
    }
}