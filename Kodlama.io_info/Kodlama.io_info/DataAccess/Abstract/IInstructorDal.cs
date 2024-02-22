using Kodlama.io_info.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io_info.DataAccess.Abstract
{
    public interface IInstructorDal
    {
        List<Instructor> GetAll();
        void Add(Instructor instructor);
        void Delete(Instructor instructorId);
        void Update(Instructor instructor);
    }
}
