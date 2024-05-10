using e_course_web.DataAccess.DbContext;
using e_course_web.Models;

namespace e_course_web.DataAccess.Repositorys
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Course = new Repository<Course>(_db);
            CourseLesson = new Repository<CourseLesson>(_db);
            CourseVideo = new Repository<CourseVideo>(_db);
            Feedback = new Repository<CourseFeedback>(_db);
            Exam = new Repository<Exam>(_db);
            ExamLesson = new Repository<ExamLesson>(_db);
            ExamQuestion = new Repository<ExamQuestion>(_db);
            Contact = new Repository<Contact>(_db);
            User = new Repository<User>(_db);
            Categories = new Repository<Categories>(_db);
            ExamHistory = new Repository<ExamHistory>(_db);
            CourseFeedback = new Repository<CourseFeedback>(_db);
            UserOrder = new Repository<UserOrder>(_db);
        }

        public IRepository<Course> Course { get; private set; }

        public IRepository<CourseLesson> CourseLesson { get; private set; }

        public IRepository<CourseVideo> CourseVideo { get; private set; }

        public IRepository<CourseFeedback> Feedback { get; private set; }

        public IRepository<Exam> Exam { get; private set; }

        public IRepository<ExamLesson> ExamLesson { get; private set; }

        public IRepository<ExamQuestion> ExamQuestion { get; private set; }

        public IRepository<Contact> Contact { get; private set; }

        public IRepository<User> User { get; private set; }

        public IRepository<Categories> Categories { get; private set; }

        public IRepository<ExamHistory> ExamHistory { get; private set; }

        public IRepository<CourseFeedback> CourseFeedback { get; private set; }

        public IRepository<UserOrder> UserOrder { get; private set; }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}