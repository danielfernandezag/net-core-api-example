using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GameCollectionAPI.Models;
using GameCollectionAPI.Repositories;
using GameCollectionAPI.Services.Communication;

namespace GameCollectionAPI.Services.Implementation
{
    public class UsersService : IUsersService
    {
        private readonly IUsersRepository usersRepository;
        private readonly IUnitOfWork unitOfWork;

        public UsersService(IUsersRepository usersRepository, IUnitOfWork unitOfWork)
        {
            this.usersRepository = usersRepository;
            this.unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<UserModel>> ListAsync()
        {
            return await this.usersRepository.ListAsync();
        }

        public async Task<SaveUserResponse> SaveAsync(UserModel user)
        {
            try
            {
                await this.usersRepository.AddAsync(user);
                await this.unitOfWork.CompleteAsync();
                return new SaveUserResponse(user);
            }
            catch (Exception ex)
            {
                return new SaveUserResponse($"An error ocurred when trying to save new user to context: {ex.Message}");
            }
        }

        public async Task<SaveUserResponse> UpdateAsync(short id, UserModel user)
        {
            var userInContext = await this.usersRepository.FindByIdAsync(id);

            if (userInContext == null)
            {
                return new SaveUserResponse("user does not exist in the context");
            }

            userInContext.firstname = user.firstname;
            userInContext.lastname = user.lastname;
            userInContext.password = user.password;

            try
            {
                this.usersRepository.Update(userInContext);
                await this.unitOfWork.CompleteAsync();
                return new SaveUserResponse(userInContext);
            }
            catch (Exception ex)
            {
                return new SaveUserResponse($"An error ocurred when trying to update user in context: {ex.Message}");
            }
        }
    }
}
