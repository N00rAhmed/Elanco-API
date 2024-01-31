using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace Elanco_API.Models
{
    public class WeatherForecast
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Name { get; set; }

        [BsonRepresentation(BsonType.Double, AllowTruncation = true)]
        public double Price { get; set; }

        public string Category { get; set; }

        public string Author { get; set; }


/*
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
*/


    }
}