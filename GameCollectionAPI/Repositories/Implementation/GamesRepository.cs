using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GameCollectionAPI.Models;
using GameCollectionAPI.Persistence.Contexts;

namespace GameCollectionAPI.Repositories.Implementation
{
    public class GamesRepository : BaseRepository, IGamesRepository 
    {
        public GamesRepository(GameCollectionDbContext context) : base(context)
        {

        }

        public async Task<IEnumerable<GameModel>> ListAsync()
        {
            return await this.context.Games.ToListAsync();
        }
    }
}
