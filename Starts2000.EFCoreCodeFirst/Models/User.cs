using System.ComponentModel.DataAnnotations;

namespace Starts2000.EFCoreCodeFirst.Models
{
    public class User
    {
        public int Id { get; set; }

        [MaxLength(32), Required]
        public string Aaccount { get; set; }

        [MaxLength(32), Required]
        public string Password { get; set; }
    }
}
