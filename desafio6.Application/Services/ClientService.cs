using desafio6.Domain.Interfaces.Repository;
using desafio6.Domain.Interfaces.Services;
using desafio6.Domain.Models;

namespace desafio6.Application.Services;

public class ClientService(IUnitOfWork iUnitOfWork): IClientService
{

    public async Task<List<ClientAddressModel>> GetAllAsync()
    {
        return await iUnitOfWork.RepositoryClientAddress.Get(x=>true);
    }
    
    public async Task<ClientAddressModel> GetById(string id)
    {
        var client = await iUnitOfWork.RepositoryClientAddress.Find(c => c.Id.ToString() == id);
        return client;
    }
    
    public async Task<int> PostClient(ClientAddressModel client)
    {
        var clientInsert = await iUnitOfWork.RepositoryClientAddress.Save(client);
        return clientInsert;
    }
    
    public async Task<bool> DeleteClient(string id)
    {
        var client = await iUnitOfWork.RepositoryClientAddress.Find(c => c.Id.ToString() == id);
        if (client is null) throw new ArgumentException("Cliente não encontrado");
        await iUnitOfWork.RepositoryClientAddress.Delete(id);
        return true;
    }
    
    public async Task<ClientAddressModel> UpdateClient(string id, ClientAddressModel client)
    {
        var clientRep = await iUnitOfWork.RepositoryClientAddress.Find(c => c.Id.ToString() == id);
        if (clientRep is null) throw new ArgumentException("Cliente não encontrado");
        clientRep.Name = client.Name;
        clientRep.Email = client.Email;
        clientRep.Address = client.Address;
        await iUnitOfWork.RepositoryClientAddress.Update(clientRep, id);
        var clientUpdate = await GetById(id);
        return clientUpdate;
    }
}