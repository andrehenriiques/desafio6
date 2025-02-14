using AutoMapper;
using desafio6.Api.Dto;
using desafio6.Domain.Interfaces.Services;
using desafio6.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;

namespace Desafio6.Api.Controllers;


[Route("api/[controller]")]
[ApiController]
public class ClientController(IClientService clientService, IMapper mapper) : ControllerBase
{
    
    [HttpGet]
    public async Task<IActionResult> GetClients()
    { 
        var clients = await clientService.GetAllAsync(); 
        return Ok(clients);
    }
 
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(string id)
    {
        var client = await clientService.GetById(id);
        return Ok(client);
    }
    
    [HttpPost]
    public async Task<IActionResult> PostClient(ClientAddressDto client)
    { 
        var mapClient = mapper.Map<ClientAddressDto, ClientAddressModel>(client);
        var clientAdd = await clientService.PostClient(mapClient);
        return Ok(clientAdd);
    }
 
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateClient([FromBody]ClientAddressDto client, string id)
    {
        var mapClient = mapper.Map<ClientAddressDto, ClientAddressModel>(client);
        var clientUpdate = await clientService.UpdateClient(id, mapClient);
        return Ok(clientUpdate);
    }
 
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteClientById(string id)
    {
        await clientService.DeleteClient(id);
        return Ok();
    }
}