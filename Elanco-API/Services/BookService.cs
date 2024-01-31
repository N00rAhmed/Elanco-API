using Elanco_API.Models;
using MongoDB.Driver;

namespace Elanco_API.Services
{
    public class BookService : IService
    {
        private readonly IMongoCollection<WeatherForecast> _books;

        public BookService(IStoreDatabaseSettings settings, IMongoClient mongoClient) 
        {
            var database = mongoClient.GetDatabase(settings.DatabaseName);
            _books = database.GetCollection<WeatherForecast>(settings.CollectionName);
        }
        public WeatherForecast Create(WeatherForecast book)
        {
            throw new NotImplementedException();
        }

        public List<WeatherForecast> Get()
        {
            return _books.Find(book => true).ToList();

            /*            throw new NotImplementedException();
            */
        }

        public WeatherForecast Get(string id)
        {
            throw new NotImplementedException();
        }

        public void Remove(string id)
        {
            throw new NotImplementedException();
        }

        public void Update(string id, WeatherForecast student)
        {
            throw new NotImplementedException();
        }
    }
}
