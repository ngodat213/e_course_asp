using e_course_web.Models;

namespace e_course_web.DataAccess.Repositorys
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Exam> Exam { get; }
        IRepository<ExamLesson> ExamLesson { get; }
        IRepository<ExamQuestion> ExamQuestion { get; }
        IRepository<Course> Course { get; }
        IRepository<CourseLesson> CourseLesson { get; }
        IRepository<CourseVideo> CourseVideo { get; }
        IRepository<CourseFeedback> Feedback { get; }
        IRepository<Contact> Contact { get; }
        IRepository<Categories> Categories { get; }
        IRepository<User> User { get; }

        IRepository<ExamHistory> ExamHistory { get; }
        IRepository<CourseFeedback> CourseFeedback { get; }
        IRepository<UserOrder> UserOrder { get; }

    }
}
