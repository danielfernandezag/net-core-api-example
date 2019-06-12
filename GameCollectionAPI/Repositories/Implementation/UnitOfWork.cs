using System.Threading.Tasks;
using GameCollectionAPI.Persistence.Contexts;

namespace GameCollectionAPI.Repositories.Implementation
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly GameCollectionDbContext context;

        public UnitOfWork(GameCollectionDbContext context)
        {
            this.context = context;
        }

        public async Task CompleteAsync()
        {
            await this.context.SaveChangesAsync();
        }
    }
}
