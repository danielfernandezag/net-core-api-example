using System.Collections.Generic;

namespace GameCollectionAPI.Models
{
    public class CollectionModel
    {
        public short id { get; set; }
        public string name { get; set; }
        public short total { get; set; }
        public short userid { get; set; }
        public UserModel user { get; set; }
        public IList<GameModel> games { get; set; } = new List<GameModel>();
    }
}


