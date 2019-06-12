using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GameCollectionAPI.Models;
using GameCollectionAPI.Persistence.Contexts;


namespace GameCollectionAPI.Repositories.Implementation
{
    public class UsersRepository : BaseRepository, IUsersRepository
    {
        public UsersRepository(GameCollectionDbContext context) : base(context)
        {

        }

        public async Task<IEnumerable<UserModel>> ListAsync()
        {
            return await this.context.Users.ToListAsync();
        }

        public async Task AddAsync(UserModel user)
        {
            await this.context.Users.AddAsync(user);
        }

        public async Task<UserModel> FindByIdAsync(short id)
        {
            return await this.context.Users.FindAsync(id);
        }

        public void Update(UserModel user)
        {
            this.context.Users.Update(user);
        }
    }
}

