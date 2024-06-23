using KolokwiumDF.DTOs;
using KolokwiumDF.Interfaces;
using KolokwiumDF.Models;

namespace KolokwiumDF.Services;

public class ClientService : IClientService
{
    private readonly IClientRepository _clientRepository;

    public ClientService(IClientRepository clientRepository)
    {
        _clientRepository = clientRepository;
    }

    public async Task<ClientDTO> GetClientByIdAsync(int idClient)
    {
        var client = await _clientRepository.GetClientByIdAsync(idClient);
        var total = 0;

        var set = new HashSet<Subscription>();
        foreach (var clientSale in client.Sales)
        {
            set.Add(clientSale.Subscription);
        }

        var sum = client.Sales.Sum(e=> e.Subscription.Price);
        var subscriptions = new List<SubscriptionDTO>();
        foreach (var s in set)
        {
            var sub = new SubscriptionDTO();
            sub.IdSubscription = s.IdSubscription;
            sub.Name = s.Name;
            sub.RenewalPeriod = s.RenewalPeriod;
            sub.TotalAmountPaid = sum;
            subscriptions.Add(sub);
        }
        
        return new ClientDTO()
        {
            FirstName = client.FirstName,
            LastName = client.LastName,
            Email = client.Email,
            Phone = client.Phone,
            subscriptions = subscriptions
        };
    }
}