using Loan.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Loan.DataAccess.Persistence.Configurations;

public class ProductEntityConfiguration:IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasMany(p => p.LoanItems)
            .WithOne(li => li.Product)
            .HasForeignKey(li => li.ProductId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}