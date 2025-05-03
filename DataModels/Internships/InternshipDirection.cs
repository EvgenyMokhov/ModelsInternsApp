using System.ComponentModel.DataAnnotations;

namespace DataModels.Internships
{
    public class InternshipDirection
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}
