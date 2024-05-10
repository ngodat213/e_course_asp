using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace e_course_web.Models
{
    public class UserOrder
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("UserId")]
        public string UserId { get; set; }
        public User User { get; set; }

        [ForeignKey("CourseId")]
        public int CourseId { get; set; }
        public Course Course { get; set; }

        public double TotalPrice {  get; set; }
        public string PaymentStatus {  get; set; }
        public string Payment {  get; set; }
        public DateTime OrderDate { get; set; }
    }
}
