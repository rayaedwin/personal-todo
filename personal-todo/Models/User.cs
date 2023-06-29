using System.ComponentModel.DataAnnotations;

namespace personal_todo.Models
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public DateTime RegisterDate { get; set; }
    }
}
