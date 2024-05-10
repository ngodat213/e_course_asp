using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace e_course_web.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Title { get; set; } //

        [Required]
        public double Price { get; set; } //

        [Required]
        public int CategoryId { get; set; } //

        [ForeignKey("CategoryId")]
        public Categories? Category { get; set; }

        [Required]
        [MaxLength(5000)]
        public string Description { get; set; }

        [Range(0.0, 5.0)]
        [DefaultValue(0)]
        public double Rating { get; set; }

        [DefaultValue(0)]
        [Range(0, int.MaxValue)]
        public int Register { get; set; }

        [Required]
        public string TeacherId { get; set; }

        [Required]
        public string ImageUrl { get; set; }
        [Required]
        public string PublicId { get; set; }

        [Required]
        public string VideoUrl { get; set; }
        [Required]
        public string PublicVideo { get; set; }

        [Required]
        [MaxLength(10)]
        public string Time { get; set; }

        [Required]
        public string Language { get; set; }

        public DateTime UpdateAt { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual List<CourseLesson> Lessons { get; set; }
    }
}
