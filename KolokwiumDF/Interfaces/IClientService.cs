using KolokwiumDF.DTOs;

namespace KolokwiumDF.Interfaces;

public interface IClientService
{ 
    Task<ClientDTO> GetClientByIdAsync(int idClient);
}