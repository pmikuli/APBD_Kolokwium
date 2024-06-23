using KolokwiumDF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KolokwiumDF.Configuration;

public class ClientConfig : IEntityTypeConfiguration<Client>
{
    public void Configure(EntityTypeBuilder<Client> builder)
    {
        builder.Property(e => e.IdClient).UseIdentityColumn();

        builder.HasMany(e => e.Sales)
            .WithOne(e => e.Client)
            .HasForeignKey(e => e.IdClient)
            .OnDelete(DeleteBehavior.ClientSetNull);
        
        var list = new List<Client>();
        list.Add(new Client()
        {
            IdClient = 1,
            FirstName = "Jan",
            LastName = "Kowalski",
            Email = "jan.Kowalski@gmail.com",
            Phone = "123456789"
        });

        builder.HasData(list);
    }
}