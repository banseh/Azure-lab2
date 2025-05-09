using System.ComponentModel.DataAnnotations;

namespace vc.d1.Models
{
    public class Addbook_Dto
    {
        [Required]
        [MinLength(10)]
        [MaxLength(30)]

        public string Name { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }  = string.Empty;

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;

    }
}
