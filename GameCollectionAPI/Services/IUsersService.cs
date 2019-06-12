using GameCollectionAPI.Models;
using System.Threading.Tasks;
using System.Collections.Generic;
using GameCollectionAPI.Services.Communication;

namespace GameCollectionAPI.Services
{
    public interface IUsersService
    {
        Task<IEnumerable<UserModel>> ListAsync(); //READ ALL
        Task<SaveUserResponse> SaveAsync(UserModel user); //SAVE NEW
        Task<SaveUserResponse> UpdateAsync(short id, UserModel user); //UPDATE BY ID
    }
}
