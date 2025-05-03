using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace DataModels.Projects
{
    [Index(nameof(ProjectId))]
    public class Project_log
    {
        [Key]
        public Guid Id { get; set; }
        public Guid ProjectId { get; set; }
        public int LogType { get; set; }
        public DateTime LogTime { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}
