using System.Collections.Generic;
using System.Threading.Tasks;
using GameCollectionAPI.Models;

namespace GameCollectionAPI.Repositories
{
    public interface IGamesRepository
    {
        Task<IEnumerable<GameModel>> ListAsync();
    }
}
