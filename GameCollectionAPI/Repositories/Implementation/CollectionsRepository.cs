using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GameCollectionAPI.Models;
using GameCollectionAPI.Persistence.Contexts;

namespace GameCollectionAPI.Repositories.Implementation
{
    public class CollectionsRepository: BaseRepository, ICollectionsRepository
    {
        public CollectionsRepository(GameCollectionDbContext context) : base(context)
        {

        }

        public async Task<IEnumerable<CollectionModel>> ListAsync()
        {
            return await this.context.Collections.ToListAsync();
        }
    }
}



