using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace Elanco_API.Models
{
    public class AnimalActivity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Name { get; set; }

        [BsonRepresentation(BsonType.Double, AllowTruncation = true)]
        public double Price { get; set; }

        public string Category { get; set; }

        public string Author { get; set; }


    }
}