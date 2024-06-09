using KolokwiumDF.DTOs;
using KolokwiumDF.Interfaces;

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
        return new ClientDTO()
        {
            FirstName = client.FirstName,
            LastName = client.LastName,
            Email = client.Email,
            Phone = client.Phone
        };
    }
}