using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace e_course_web.Models
{
    public class Exam
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(10000)]
        public string Description { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        [Required] 
        public string PublicId { get; set; }
        [Required]
        [MaxLength(255)]
        public string Title { get; set; }
        [Required]
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public Categories? Category { get; set; }

        public DateTime UpdateAt { get; set; }

        public DateTime CreatedAt { get; set; }

        [Required]
        public virtual List<ExamLesson> Lessons { get; set; }
    }
}