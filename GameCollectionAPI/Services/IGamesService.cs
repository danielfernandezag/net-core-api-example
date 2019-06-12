using GameCollectionAPI.Models;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace GameCollectionAPI.Services
{
    public interface IGamesService
    {
        Task<IEnumerable<GameModel>> ListAsync();
    }
}
