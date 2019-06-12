using System.Threading.Tasks;

namespace GameCollectionAPI.Repositories
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}
