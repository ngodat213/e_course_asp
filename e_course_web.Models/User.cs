using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace e_course_web.Models
{
    public class User : IdentityUser
    {
        [Required]
        public string FullName { get; set; }
        public string? PhotoUrl { get; set; }
        public string? PublicId {  get; set; }
        public string? Expert { get; set; }
        public string? Introduce { get; set; }
        public string? Description { get; set; }

        [NotMapped]
        public string Role { get; set; }
    }
}