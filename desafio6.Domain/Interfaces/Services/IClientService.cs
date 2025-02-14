using desafio6.Domain.Models;

namespace desafio6.Domain.Interfaces.Services;

public interface IClientService
{
    public Task<List<ClientAddressModel>> GetAllAsync();
    public Task<ClientAddressModel> GetById(string id);
    public Task<int> PostClient(ClientAddressModel client);
    public Task<bool> DeleteClient(string id);
    public Task<ClientAddressModel> UpdateClient(string id, ClientAddressModel client);
}