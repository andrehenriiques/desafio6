
using desafio6.Domain.Models;
using IMongo = desafio6.Domain.Interfaces.Mongo;using System.Threading.Tasks;

namespace desafio6.Domain.Interfaces.Repository
{
    public interface IUnitOfWork
    {
		//methods
            IMongo.IRepositoryBase<ClientAddressModel> RepositoryClientAddress { get; } 
    }
}