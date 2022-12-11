using System;
using System.Collections.Generic;

namespace ForeignLanguageCoursesService
{
    public class CourseService : ICourseService
    {
        private static List<Course> _courses;

        public CourseService()
        {
            if (_courses == null)
            {
                _courses = new List<Course>
                {
                    new Course
                    {
                        Id = 1,
                        Name = "Ukrainian",
                        Price = 45,
                        StartDate = new DateTime(2023, 1, 1)
                    },
                    new Course
                    {
                        Id = 2,
                        Name = "German",
                        Price = 80,
                        StartDate = new DateTime(2023, 2, 5)
                    },
                    new Course
                    {
                        Id = 3,
                        Name = "Polish",
                        Price = 90,
                        StartDate = new DateTime(2023, 4, 10)
                    },
                    new Course
                    {
                        Id = 4,
                        Name = "English",
                        Price = 100,
                        StartDate = new DateTime(2023, 5, 15)
                    }
                };
            }
        }

        public void AddCourse(Course course)
        {
            _courses.Add(course);
        }

        public IEnumerable<Course> GetCourses()
        {
            return _courses;
        }

        public Course GetCourse(int courseId)
        {
            Course course = _courses.Find(c => c.Id == courseId);

            return new Course
            {
                Id = course.Id,
                Name = course.Name,
                Price = course.Price,
                StartDate = course.StartDate
            };
        }

        public void DeleteCourse(Course course)
        {
            _courses.Remove(course);
        }

        public void UpdateCourse(Course course)
        {
            Course updateEntity = _courses.Find(c => c.Id == course.Id);

            if (updateEntity == null)
                return;

            updateEntity.Name = course.Name;
            updateEntity.Price = course.Price;
            updateEntity.StartDate = course.StartDate;
        }
    }
}
