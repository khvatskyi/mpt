using System.Collections.Generic;
using System.ServiceModel;

namespace ForeignLanguageCoursesService
{
    [ServiceContract]
    public interface ICourseService
    {
        [OperationContract]
        void AddCourse(Course course);

        [OperationContract]
        IEnumerable<Course> GetCourses();

        [OperationContract]
        Course GetCourse(int courseId);

        [OperationContract]
        void DeleteCourse(Course course);

        [OperationContract]
        void UpdateCourse(Course course);
    }
}
