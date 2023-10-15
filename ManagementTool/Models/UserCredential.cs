using System.ComponentModel.DataAnnotations;

namespace ManagementTool.Models
{
    public class UserCredential
    {
        public string Id { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
