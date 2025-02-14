using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace desafio6.Data.Mongo.Entity
{
    public class ClientAddress:EntityBase
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public Address Address { get; set; }
    }
    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
    }
}
    
