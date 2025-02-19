using MassTransit;
using desafio6.Application.Services;
using desafio6.Domain.Interfaces.Mongo;
using desafio6.Data.Mongo.Repository;
using desafio6.Data.Mongo.Context;
using desafio6.Data.Repository;
using desafio6.Domain.Interfaces.Repository;
using desafio6.Domain.Interfaces.Services;
using desafio6.Domain.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace desafio6.IoC;

public class DependencyContainer
{
    public static void RegisterServices(IServiceCollection services
,string? mongoConnectionString, ConfigurationManager configuration)
    {
        //Context
        services.AddScoped<MongoContext>(provider =>
        {
            return new MongoContext(mongoConnectionString);
        });
        //Services
        services.AddScoped<IClientService, ClientService>();
        string? busConnectionstring = configuration.GetConnectionString("RabbitMq");
        services.AddMassTransit(x =>
        {
            x.UsingRabbitMq((context, cfg) =>
            {
                cfg.Host(busConnectionstring);
                cfg.Message<ClientAddressModel>(x => x.SetEntityName("create-client"));
            });
        });

        //Extensions        
        //Unit of Work

        services.AddScoped<IUnitOfWork, UnitOfWork>();
        //Repositorys
        
	}
}