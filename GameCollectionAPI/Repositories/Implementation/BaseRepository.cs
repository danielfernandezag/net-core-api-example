using GameCollectionAPI.Persistence.Contexts;
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