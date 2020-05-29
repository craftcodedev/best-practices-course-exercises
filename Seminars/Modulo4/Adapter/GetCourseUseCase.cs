namespace Directos.Module4.Adapter
{
    public class FindAllCoursesUseCase
    {
        private ICourseRepository courseRepository;
        private CourseConverter courseConverter;

        public FindAllCoursesUseCase (ICourseRepository courseRepository, CourseConverter courseConverter)
        {
            this.courseRepository = courseRepository;
            this.courseConverter = courseConverter;
        }

        public List<CourseDTO> Execute ()
        {
            List<Course> courses = this.courseRepository.FindAllCourses ();
            List<CourseDTO> courseDtos = new List<CourseDTO> ();
            
            foreach (var course in courses) {
                courseDtos.Add (this.courseConverter.Convert (course));
            }

            return courseDtos;
        }
    }
}