using Kodlama.io_info.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io_info.DataAccess.Abstract
{
    public interface ICourseDal
    {
        List<Course> GetAll();
        void Add(Course course);
        void Delete(Course courseId);
        void Update(Course course);

    }
}
