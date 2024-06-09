using KolokwiumDF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KolokwiumDF.Configuration;

public class SubscriptionConfiguration : IEntityTypeConfiguration<Subscription>
{
    public void Configure(EntityTypeBuilder<Subscription> builder)
    {
        builder.Property(e => e.IdSubscription).UseIdentityColumn();

        var list = new List<Subscription>(); 
        
        list.Add(new Subscription()
        {
            IdSubscription = 1,
            Name = "AAA",
            RenewalPeriod = 1,
            EndTime = DateTime.Now,
            Price = 300
        });

        builder.HasData(list);
    }
}