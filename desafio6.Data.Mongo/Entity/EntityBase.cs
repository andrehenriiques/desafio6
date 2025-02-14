using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace desafio6.Data.Mongo.Entity
{
    public class EntityBase
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public bool Active { get; set; }
    }
}