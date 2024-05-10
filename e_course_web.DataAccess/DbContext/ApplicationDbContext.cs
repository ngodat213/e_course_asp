using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using e_course_web.Models;

namespace e_course_web.DataAccess.DbContext
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        // COURSE
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseLesson> CourseLessons { get; set; }
        public DbSet<CourseVideo> CourseVideos { get; set; }
        public DbSet<CourseFeedback> CourseFeedbacks { get; set; }

        // EXAM
        public DbSet<Exam> Exams { get; set; }
        public DbSet<ExamLesson> ExamLessons { get; set; }
        public DbSet<ExamQuestion> ExamQuestions { get; set; }
        public DbSet<ExamHistory> ExamHistorys { get; set; }

        // USER
        public DbSet<UserOrder> UserOrders { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<User> ApplicationUser { get; set; }

    }
}
