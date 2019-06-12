using System.Collections.Generic;
using System.Threading.Tasks;
using GameCollectionAPI.Models;
using GameCollectionAPI.Repositories;

namespace GameCollectionAPI.Services.Implementation
{
    public class GamesService : IGamesService
    {
        private readonly IGamesRepository gamesRepository;

        public GamesService(IGamesRepository gamesRepository)
        {
            this.gamesRepository = gamesRepository;
        }

        public async Task<IEnumerable<GameModel>> ListAsync()
        {
            return await this.gamesRepository.ListAsync();
        }
    }
}
