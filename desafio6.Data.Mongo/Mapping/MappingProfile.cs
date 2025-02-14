using AutoMapper;
using Entity =  desafio6.Data.Mongo.Entity;
using Model = desafio6.Domain.Models;

namespace desafio6.Data.Mongo.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            var cInfo = System.Globalization.CultureInfo.InvariantCulture;
			//mappings
            CreateMap<Model.AddressModel,Entity.Address>().ReverseMap(); 
            CreateMap<Model.ClientAddressModel,Entity.ClientAddress>().ReverseMap(); 
        }
    }
}