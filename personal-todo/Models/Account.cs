using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace personal_todo.Models
{
    public class Account
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public Guid UserId { get; set; }

        [Required]
        public string Password { get; set; }

        [ForeignKey(nameof(UserId))]
        public User? User { get; set; }
    }
}
