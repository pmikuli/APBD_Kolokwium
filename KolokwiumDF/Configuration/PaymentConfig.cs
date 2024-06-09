using KolokwiumDF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KolokwiumDF.Configuration;

public class PaymentConfig : IEntityTypeConfiguration<Payment>
{
    public void Configure(EntityTypeBuilder<Payment> builder)
    {
        builder.Property(e => e.IdPayment).UseIdentityColumn();

        var list = new List<Payment>();
        list.Add(new Payment()
        {
            Date = DateTime.Now,
            IdClient = 1,
            IdPayment = 1,
            IdSubcription = 1
        });
        builder.HasData(list);
    }
}