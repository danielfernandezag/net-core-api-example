using System.Collections.Generic;
using System.Threading.Tasks;
using GameCollectionAPI.Models;

namespace GameCollectionAPI.Repositories
{
    public interface IUsersRepository
    {
        Task<IEnumerable<UserModel>> ListAsync();
        Task AddAsync(UserModel user);
        Task<UserModel> FindByIdAsync(short id);
        void Update(UserModel user);
    }
}
