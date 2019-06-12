using GameCollectionAPI.Models;

namespace GameCollectionAPI.Services.Communication
{
    public class SaveUserResponse : BaseResponse
    {
        public UserModel User { get; protected set; }

        private SaveUserResponse(bool success, string message, UserModel user) : base(success, message)
        {
            User = user;
        }

        public SaveUserResponse(UserModel user) : this(true, string.Empty, user)
        {

        }

        public SaveUserResponse(string message) : this(true, message, null)
        {

        }

    }
}
