using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_course_web.Models
{
    public class ExamHistory
    {
        [Key]
        public int Id {  get; set; }
        [ForeignKey("UserId")]
        public string UserId {  get; set; }
        public User User { get; set; }

        [ForeignKey("ExamId")]
        public int ExamId {  get; set; }
        public Exam Exam { get; set; }
        public double Point {  get; set; }

        public DateTime SubmitDate { get; set; }
    }
}
