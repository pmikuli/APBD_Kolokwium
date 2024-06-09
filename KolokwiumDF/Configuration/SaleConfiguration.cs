using KolokwiumDF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KolokwiumDF.Configuration;

public class SaleConfiguration : IEntityTypeConfiguration<Sale>
{
    public void Configure(EntityTypeBuilder<Sale> builder)
    {
        builder.Property(e => e.IdSale).UseIdentityColumn();

        builder.HasOne(e => e.Subscription)
            .WithMany(e => e.Sales)
            .HasForeignKey(e => e.IdSubscription)
            .OnDelete(DeleteBehavior.ClientSetNull);

        builder.HasOne(e => e.Client)
            .WithMany(e => e.Sales)
            .HasForeignKey(e => e.IdClient)
            .OnDelete(DeleteBehavior.ClientSetNull);

        var list = new List<Sale>();
        list.Add(new Sale()
        {
            IdSale = 1,
            IdClient  = 1,
            CreatedAt = DateTime.Now,
            IdSubscription = 1
        });

        builder.HasData(list);
    }
}