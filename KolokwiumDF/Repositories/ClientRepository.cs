using KolokwiumDF.Interfaces;
using KolokwiumDF.Models;

namespace KolokwiumDF.Repositories;

public class ClientRepository : IClientRepository
{
    private readonly Context _context;

    public ClientRepository(Context context)
    {
        _context = context;
    }
    
    public async Task<Client> GetClientByIdAsync(int clientId)
    {
        var result = await _context.Clients.FindAsync(clientId);
        // var res = _context.Clients
        //     .Select(e => new Client()
        //     {
        //         FirstName = e.FirstName,
        //         LastName = e.LastName,
        //         Email = e.Email,
        //         Phone = e.Phone,
        //         Discount = e.Discount
        //     })
        //     .ToList();

        if (result != null)
        {
            return result;
        }
        else
        {
            throw new Exception("Cant find the client");
        }
    }
}