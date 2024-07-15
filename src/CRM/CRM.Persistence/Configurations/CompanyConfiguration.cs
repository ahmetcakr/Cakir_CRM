using CRM.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CRM.Persistence.Configurations;

public class CompanyConfiguration : IEntityTypeConfiguration<Company>
{
    public void Configure(EntityTypeBuilder<Company> builder)
    {
        builder.ToTable("Companies").HasKey(c => c.Id);

        builder.HasKey(c => c.Id);
        builder.Property(c => c.Id).HasColumnName("Id").IsRequired();
        builder.Property(c => c.CompanyName).HasColumnName("CompanyName").IsRequired();
        builder.Property(c => c.CompanyTypeId).HasColumnName("CompanyTypeId").IsRequired();

        builder.HasOne(c => c.CompanyType)
            .WithMany()
            .HasForeignKey(c => c.CompanyTypeId);
    }
}
