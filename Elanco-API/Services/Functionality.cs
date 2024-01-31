using Elanco_API.Models;
using MongoDB.Driver;

namespace Elanco_API.Services
{
    public class Functionality : Http_Requests
    {
        private readonly IMongoCollection<AnimalActivity> _books;

        public Functionality(IStoreDatabaseSettings settings, IMongoClient mongoClient) 
        {
            var database = mongoClient.GetDatabase(settings.DatabaseName);
            _books = database.GetCollection<AnimalActivity>(settings.CollectionName);
        }
        public AnimalActivity Create(AnimalActivity book)
        {
            throw new NotImplementedException();
        }

        public List<AnimalActivity> Get()
        {
            return _books.Find(book => true).ToList();

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

        public void Update(string id, AnimalActivity student)
        {
            throw new NotImplementedException();
        }
    }
}
