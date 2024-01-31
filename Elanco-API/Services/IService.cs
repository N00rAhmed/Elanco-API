using Elanco_API.Models;

namespace Elanco_API.Services
{
    public interface IService
    {
        List<WeatherForecast> Get();
        WeatherForecast Get(string id);
        WeatherForecast Create(WeatherForecast student);
        void Update(string id, WeatherForecast student);
        void Remove(string id);

    }
}
