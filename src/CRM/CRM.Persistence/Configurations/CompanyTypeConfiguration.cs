using CRM.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CRM.Persistence.Configurations;

public class CompanyTypeConfiguration : IEntityTypeConfiguration<CompanyType>
{
    public void Configure(EntityTypeBuilder<CompanyType> builder)
    {
        builder.ToTable("CompanyTypes").HasKey(c => c.Id);

        builder.Property(c => c.TypeName).HasColumnName("TypeName").IsRequired();

        builder.HasMany(c => c.Companies)
            .WithOne(c => c.CompanyType)
            .HasForeignKey(c => c.CompanyTypeId);

    }
}
