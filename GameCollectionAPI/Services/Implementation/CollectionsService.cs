using System.Collections.Generic;
using System.Threading.Tasks;
using GameCollectionAPI.Models;
using GameCollectionAPI.Repositories;

namespace GameCollectionAPI.Services.Implementation
{
    public class CollectionsService : ICollectionsService
    {
        private readonly ICollectionsRepository collectionsRepository;

        public CollectionsService(ICollectionsRepository collectionsRepository)
        {
            this.collectionsRepository = collectionsRepository;
        }

        public async Task<IEnumerable<CollectionModel>> ListAsync()
        {
            return await this.collectionsRepository.ListAsync();
        }
    }
}
