using Kodlama.io_info.DataAccess.Abstract;
using Kodlama.io_info.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io_info.DataAccess.Concrete
{
    public class CourseDal : ICourseDal
    {
        List<Course> _courses;

        public CourseDal()
        {
            _courses = new List<Course>()
            {
                new Course() { CourseId=1,CategoryId=1 ,InstructorId=1, CourseName=".Net",Description="Senior yazılımcı geliştirme kampı",Price=0 },
                new Course() { CourseId=2,CategoryId=2 ,InstructorId=1, CourseName="JavaScript",Description="Sıfırdan Başlıyoruz",Price=0 },
                new Course() { CourseId=3,CategoryId=3 ,InstructorId=2, CourseName="Selenium",Description="Python & Selenium",Price=0 },
                new Course() { CourseId=4,CategoryId=1 ,InstructorId=1, CourseName="Java",Description="Java - React",Price=0 },
                new Course() { CourseId=5,CategoryId=1 ,InstructorId=1, CourseName="C#",Description="C# - Angular",Price=0 },
                new Course() { CourseId=6,CategoryId=4 ,InstructorId=1, CourseName="Programlamaya Giriş",Description="Sıfırdan Başlıyoruz",Price=0 }
            };
        }

        public void Add(Course course)
        {
            _courses.Add(course);
        }

        public void Delete(Course courseId)
        {

            var courseToRemove = _courses.SingleOrDefault(c => c.CourseId.Equals(courseId));
            if (courseToRemove != null)
            {
                _courses.Remove(courseToRemove);
            }
        }

        public List<Course> GetAll()
        {
            return _courses.ToList();
        }

        public void Update(Course course)
        {
            var updateToCourse = _courses.SingleOrDefault(c => c.CourseId.Equals(course));

            if (updateToCourse != null)
            {
                updateToCourse.CategoryId = course.CategoryId;
                updateToCourse.InstructorId = course.InstructorId;
                updateToCourse.CourseName = course.CourseName;
                updateToCourse.Description = course.Description;
                updateToCourse.Price = course.Price;

                Console.WriteLine("Kurs güncellendi : {0}", updateToCourse.CourseName);
            }
            else
            {
                Console.WriteLine("Belirtilen ID'ye sahip bir kurs bulunamadı.");
            }
        }
    }
}
