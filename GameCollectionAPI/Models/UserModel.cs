using System.Collections.Generic;
namespace GameCollectionAPI.Models
{
    public class UserModel
    {
        public short id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string password { get; set; }
        public IList<CollectionModel> collections { get; set; } = new List<CollectionModel>();
    }

}
