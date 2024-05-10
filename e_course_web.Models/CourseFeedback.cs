using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace e_course_web.Models
{
    public class CourseFeedback
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("UserId")]
        public string UserId { get; set; }
        public User User { get; set; }

        [ForeignKey("CourseId")]
        public int CourseId { get; set; }
        public Course Course { get; set; }

        [Required]
        public string Title { get; set; }
        [Required]
        [Range(0, 5)]
        public double Rating { get; set; }
    }
}