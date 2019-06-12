using System.ComponentModel.DataAnnotations;

namespace GameCollectionAPI.Models.Resources
{
    public class SaveCollectionResource
    {
        [Required]
        [MaxLength(50)]
        public string name { get; set; }
        [Required]
        public short total { get; set; }
        [Required]
        public short userid { get; set; }
    }
}
