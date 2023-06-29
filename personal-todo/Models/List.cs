using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace personal_todo.Models
{
    public class List
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public Guid UserId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Color { get; set; }

        [ForeignKey(nameof(UserId))]
        public User? User { get; set; }

        public virtual ICollection<Task>? Tasks { get; set; }

    }
}
