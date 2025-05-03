using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace DataModels.Internships
{
    [Index(nameof(InternshipDirectionId))]
    public class InternshipDirection_log
    {
        [Key]
        public Guid Id { get; set; }
        public Guid InternshipDirectionId { get; set; }
        public int LogType { get; set; }
        public DateTime LogTime { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}
