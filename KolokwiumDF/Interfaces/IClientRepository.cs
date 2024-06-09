using KolokwiumDF.DTOs;
using KolokwiumDF.Models;

namespace KolokwiumDF.Interfaces;

public interface IClientRepository
{
    Task<Client> GetClientByIdAsync(int clientId);
}