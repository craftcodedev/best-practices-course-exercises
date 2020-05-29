namespace Directos.Module4.Adapter
{
    public class Course
    {
        private string courseId;
        private string courseTitle;

        private Course(string courseId, string courseTitle)
        {
            this.courseId = courseId;
            this.courseTitle = courseTitle;
        }

        public static Course SingUp(string courseId, string courseTitle)
        {
            return new Course(courseId, courseTitle);
        }

        public string Id()
        {
            return courseId;
        }

        public string Title()
        {
            return courseTitle;
        }
    }
}