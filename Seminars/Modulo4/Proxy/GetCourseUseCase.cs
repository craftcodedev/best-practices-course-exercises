namespace Directos.Module4.Proxy
{
    public class GetCourseUseCase
    {       
       private ICourseRepository courseRepository;
       private CourseConverter converter;
       private Cache cache;
      
       public GetCourseUseCase(ICourseRepository courseRepository, CourseConverter converter,Cache cache)
       {
           this.courseRepository = courseRepository;
           this.converter = converter;
           this.cache = cache;
       }
 
 
       public CourseDTO Execute(string id)
       {
           string data = this.cache.Get("data-" + id);
           Course course;
           if (String.IsNullOrEmpty(data)) course = this.courseRepository.FindById(Int16.Parse(id));
           else course = JsonSerializer.Deserialize<Course>(data);
 
           CourseDTO courseDTO = converter.Convert(course);
           return courseDTO;
       }
    }
}