using Elanco_API.Models;

namespace Elanco_API.Services
{
    public interface Http_Requests
    {
        List<AnimalActivity> Get();
        AnimalActivity Get(string id);
        AnimalActivity Create(AnimalActivity student);
        void Update(string id, AnimalActivity student);
        void Remove(string id);

    }
}
