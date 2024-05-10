using System.ComponentModel.DataAnnotations;

namespace e_course_web.Models
{
    public class ExamQuestion
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Question { get; set; }
        [Required]
        public int Answer { get; set; }
        public string? ImageUrl {  get; set; }
        public string? PublicId {  get; set; }
        [Required]
        public string Option { get; set; }
    }
}