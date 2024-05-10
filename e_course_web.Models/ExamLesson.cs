using System.ComponentModel.DataAnnotations;

namespace e_course_web.Models
{
    public class ExamLesson
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int Hour { get; set; }
        [Required]
        public int Minute { get; set; }
        [Required]
        public int Second { get; set; }
        [Required]
        public int Lesson { get; set; }
        [Required]
        public double Point { get; set; }
        [Required]
        public virtual List<ExamQuestion> ExamQuestion { get; set; }
    }
}