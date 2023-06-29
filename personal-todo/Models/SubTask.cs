using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace personal_todo.Models
{
    public enum SubTaskStatus
    {
        Created, Completed
    }

    public class SubTask
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public Guid TaskId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public SubTaskStatus Status { get; set;}

        [ForeignKey(nameof(TaskId))]
        public Task? Task { get; set; }
    }
}
