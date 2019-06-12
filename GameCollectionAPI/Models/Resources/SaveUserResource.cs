using System.ComponentModel.DataAnnotations;

namespace GameCollectionAPI.Models.Resources
{
    public class SaveUserResource
    {
        [Required]
        [MaxLength(50)]
        public string firstname { get; set; }
        [MaxLength(50)]
        public string lastname { get; set; }
        [Required]
        [MaxLength(100)]
        public string password { get; set; }
    }
}
