using Kodlama.io_info.Business.Abstract;
using Kodlama.io_info.DataAccess.Abstract;
using Kodlama.io_info.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io_info.Business.Concrete
{
    public class CourseService : ICourseService
    {
        ICourseDal _courseDal;

        public CourseService(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public void Add(Course course)
        {
           _courseDal.Add(course);
        }

        public void Delete(Course courseId)
        {
            _courseDal.Delete(courseId);
        }

        public List<Course> GetAll()
        {
           return _courseDal.GetAll();  
        }

        public void Update(Course course)
        {
            _courseDal.Update(course);
        }
    }
}
