using System.Collections.Generic;
using System.Threading.Tasks;
using GameCollectionAPI.Models;

namespace GameCollectionAPI.Repositories
{
    public interface ICollectionsRepository
    {
        Task<IEnumerable<CollectionModel>> ListAsync();
    }
}


