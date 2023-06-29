using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace personal_todo.Models
{
    public enum TaskPriority { Low, Medium, High }

    public enum TaskStatus { Created, InProgress, Completed }

    public class Task
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public Guid ListId { get; set; }

        [Required]
        public string Name { get; set; }

        public string? Description { get; set; }

        [Required]
        public TaskPriority Priority { get; set; }

        [Required]
        public TaskStatus Status { get; set; }

        [Required]
        public DateTime DateCreated { get; set; }

        [Required]
        public DateTime DueDate { get; set; }

        public DateTime? DateCompleted { get; set; }

        [ForeignKey(nameof(ListId))]
        public List? List { get; set; }

    }
}
