using KolokwiumDF.Interfaces;
using KolokwiumDF.Models;
using Microsoft.EntityFrameworkCore;

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
        return (await _context.Clients
            .Where(e => e.IdClient == clientId)
            .Include(c => c.Sales)
            .ThenInclude(s => s.Subscription)
            .FirstOrDefaultAsync(c => c.IdClient == clientId))!;
    }
}