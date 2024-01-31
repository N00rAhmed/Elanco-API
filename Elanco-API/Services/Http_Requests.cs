using Elanco_API.Models;

namespace Elanco_API.Services
{
    public interface Http_Requests
    {
        List<AnimalActivity> Get();
        AnimalActivity Get(string id);
        AnimalActivity Create(AnimalActivity animal_activity_data);
        void Update(string id, AnimalActivity animal_activity_data);
        void Remove(string id);

    }
}
