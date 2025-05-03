using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace DataModels.Interns
{
    [Index(nameof(InternId))]
    public class Intern_log
    {
        [Key]
        public Guid Id { get; set; }
        public Guid InternId { get; set; }
        public int LogType { get; set; }
        public DateTime LogTime { get; set; }
        public Guid UserId { get; set; }
        public Guid InternshipDirectionId { get; set; }
        public Guid ProjectId { get; set; }
    }
}
