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
    public class InstructorService : IInstructorService
    {
        IInstructorDal _instructorDal;

        public InstructorService(IInstructorDal instructorDal)
        {
            _instructorDal= instructorDal;
        }

        public void Add(Instructor instructor)
        {
            _instructorDal.Add(instructor);
        }

        public void Delete(Instructor instructorId)
        {
            _instructorDal.Delete(instructorId);
        }

        public List<Instructor> GetAll()
        {
           return _instructorDal.GetAll();
        }

        public void Update(Instructor instructor)
        {
            _instructorDal.Update(instructor);
        }
    }
}
