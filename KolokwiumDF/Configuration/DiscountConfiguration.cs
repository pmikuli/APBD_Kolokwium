using KolokwiumDF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KolokwiumDF.Configuration;

public class DiscountConfiguration : IEntityTypeConfiguration<Discount>
{
    public void Configure(EntityTypeBuilder<Discount> builder)
    {
        builder.Property(e => e.IdDiscount).UseIdentityColumn();

        builder.HasOne(e => e.Client)
            .WithMany(e => e.Discounts)
            .HasForeignKey(e => e.IdClient)
            .OnDelete(DeleteBehavior.ClientSetNull);

        var list = new List<Discount>();
        list.Add(new Discount()
        {
            IdClient = 1,
            DateFrom = DateTime.Now,
            IdDiscount = 1,
            Value = 10
        });
    }
}