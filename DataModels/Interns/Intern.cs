using System.ComponentModel.DataAnnotations;

namespace DataModels.Interns
{
    public class Intern
    {
        [Key]
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid InternshipDirectionId { get; set; }
        public Guid ProjectId { get; set; }
    }
}
