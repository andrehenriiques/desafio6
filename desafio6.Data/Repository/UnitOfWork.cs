
using MongoRepo = desafio6.Data.Mongo.Repository;
using IMongo = desafio6.Domain.Interfaces.Mongo;
using MongoModel = desafio6.Domain.Models;
using MongoEntity = desafio6.Data.Mongo.Entity;
using desafio6.Data.Mongo.Context;using System.Threading.Tasks;
using desafio6.Domain.Interfaces.Repository;

namespace desafio6.Data.Repository
{
    public class UnitOfWork : IUnitOfWork
    {

		        //contexts
        private readonly MongoContext _mongoContext;
                //repositorys
        private IMongo.IRepositoryBase<MongoModel.ClientAddressModel>? _repositoryClientAddress; 
                
                public UnitOfWork(
        MongoContext mongoContext)
                {
			        //constructor
        _mongoContext = mongoContext;
        //repositoryInject
            
        }

      //injections
        public IMongo.IRepositoryBase<MongoModel.ClientAddressModel> RepositoryClientAddress => _repositoryClientAddress ?? (_repositoryClientAddress = new MongoRepo.RepositoryBase<MongoModel.ClientAddressModel, MongoEntity.ClientAddress>(_mongoContext, "clientaddress")); 

    }
}