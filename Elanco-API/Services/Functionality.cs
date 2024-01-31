using Elanco_API.Models;
using MongoDB.Driver;

namespace Elanco_API.Services
{
    public class Functionality : Http_Requests
    {
        private readonly IMongoCollection<AnimalActivity> animal_data;

        public Functionality(IStoreDatabaseSettings settings, IMongoClient mongoClient) 
        {
            var database = mongoClient.GetDatabase(settings.DatabaseName);
            animal_data = database.GetCollection<AnimalActivity>(settings.CollectionName);
        }
        public AnimalActivity Create(AnimalActivity animal_activity_data)
        {
            throw new NotImplementedException();
        }

        public List<AnimalActivity> Get()
        {
            return animal_data.Find(animal_activity_data => true).ToList();

            /*            throw new NotImplementedException();
            */
        }

        public AnimalActivity Get(string id)
        {
            throw new NotImplementedException();
        }

        public void Remove(string id)
        {
            throw new NotImplementedException();
        }

        public void Update(string id, AnimalActivity animal_activity_data)
        {
            throw new NotImplementedException();
        }
    }
}
