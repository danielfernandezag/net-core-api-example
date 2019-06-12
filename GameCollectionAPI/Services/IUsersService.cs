using GameCollectionAPI.Models;
using System.Threading.Tasks;
using System.Collections.Generic;
using GameCollectionAPI.Services.Communication;

namespace GameCollectionAPI.Services
{
    public interface IUsersService
    {
        Task<IEnumerable<UserModel>> ListAsync(); //GET ALL
        Task<UserResponse> FindAsync(short id); //GET BY ID
        Task<UserResponse> SaveAsync(UserModel user); //SAVE NEW
        Task<UserResponse> UpdateAsync(short id, UserModel user); //UPDATE BY ID
        Task<UserResponse> RemoveAsync(short id); //DELETE BY ID
    }
}
