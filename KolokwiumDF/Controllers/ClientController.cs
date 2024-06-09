using KolokwiumDF.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace KolokwiumDF.Controllers;

[ApiController]
[Route("api/client")]
public class ClientController : ControllerBase
{
    private readonly IClientService _clientService;
    
    public ClientController(IClientService clientService)
    {
        _clientService = clientService;
    }
    
    [HttpGet]
    public async Task<IActionResult> GetClientById([FromQuery(Name = "idKlienta")] int clientId)
    {
        var result = await _clientService.GetClientByIdAsync(clientId);
        return Ok(result);
    }
}