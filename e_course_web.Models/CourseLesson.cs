using System.ComponentModel.DataAnnotations;

namespace e_course_web.Models
{
    public class CourseLesson
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int Lesson { get; set; }
        public virtual List<CourseVideo> Videos { get; set; }
    }
}