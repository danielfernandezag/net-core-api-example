using GameCollectionAPI.Models;

namespace GameCollectionAPI.Services.Communication
{
    public class UserResponse : BaseResponse
    {
        public UserModel User { get; protected set; }

        private UserResponse(bool success, string message, UserModel user) : base(success, message)
        {
            User = user;
        }

        public UserResponse(UserModel user) : this(true, string.Empty, user)
        {

        }

        public UserResponse(string message) : this(false, message, null)
        {

        }

    }
}
