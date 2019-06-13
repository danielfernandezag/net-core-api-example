using GameCollectionAPI.Persistence.Contexts;
using System;

namespace GameCollectionAPI.Repositories.Implementation
{
    public abstract class BaseRepository
    {
        protected readonly GameCollectionDbContext context;

        public BaseRepository(GameCollectionDbContext context)
        {
            this.context = context;
        }

    }
}