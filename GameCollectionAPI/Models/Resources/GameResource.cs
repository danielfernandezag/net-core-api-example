﻿namespace GameCollectionAPI.Models.Resources
{
    public class GameResource
    {
        public short id { get; set; }
        public string name { get; set; }
        public short year { get; set; }
        public string platform { get; set; }
        public string genre { get; set; }
        public string developer { get; set; }
        public string publisher { get; set; }
        public bool obtained { get; set; }
        public short collectionid { get; set; }
    }
}
