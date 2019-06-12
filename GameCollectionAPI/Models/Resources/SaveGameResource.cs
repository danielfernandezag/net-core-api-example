using System.ComponentModel.DataAnnotations;

namespace GameCollectionAPI.Models.Resources
{
    public class SaveGameResource
    {
        [Required]
        public string name { get; set; }
        public short year { get; set; }
        [Required]
        [MaxLength(50)]
        public string platform { get; set; }
        [MaxLength(50)]
        public string genre { get; set; }
        [MaxLength(100)]
        public string developer { get; set; }
        [MaxLength(100)]
        public string publisher { get; set; }
        [Required]
        public bool obtained { get; set; }
        [Required]
        public short collectionid { get; set; }
    }
}




  
