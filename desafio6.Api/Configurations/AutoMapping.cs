using AutoMapper;
using desafio6.Api.Dto;
using desafio6.Data.Mongo.Entity;
using desafio6.Domain.Models;

namespace desafio6.Api.Configurations;

public class AutoMapping: Profile
{
    public AutoMapping()
    {
        CreateMap<AddressModel, AddressDto>().ReverseMap();
        CreateMap<ClientAddressModel, ClientAddressDto>().ReverseMap();
    }
}