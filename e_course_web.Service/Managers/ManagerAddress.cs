namespace e_course_web.Service.Manager
{
    public static class ManagerAddress
    {
        // Course address public id
        public static string PublicId_Course = "course/";
        public static string PublicId_CourseImages = $"{PublicId_Course}/images/";
        public static string PublicId_CourseVideos = $"{PublicId_Course}/videos/";
        public static string PublicId_CourseIntroduces = $"{PublicId_Course}/introduces/";
        // Exam address public id
        public static string PublicId_Exam = "exam/";
        public static string PublicId_ExamImage = $"{PublicId_Exam}/images/";
        public static string PublicId_ExamQuestions = $"{PublicId_Exam}/questions/";
        // User address public id
        public static string PublicId_User = "user/";
        public static string PublicId_UserPhoto = $"{PublicId_User}/photos";
    }
}
