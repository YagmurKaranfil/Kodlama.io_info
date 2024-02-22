using Kodlama.io_info.DataAccess.Abstract;
using Kodlama.io_info.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io_info.DataAccess.Concrete
{
    public class InstructorDal : IInstructorDal
    {
        List<Instructor> _instructors;
        public InstructorDal()
        {
            _instructors = new List<Instructor>()
            {
                 new Instructor() {InstructorId=1 , FirstName="Engin", LastName="Demiroğ",Description="Microsoft Certified Trainer (MCT) ,PMP ve ITIL sertifikalarına sahibim."},
                 new Instructor() {InstructorId=2 , FirstName="Halit Enes", LastName="Kalaycı",Description="Eğitim ve danışmanlık verdiğim kurumların bazıları; Esbaş, Etiya, KDK, Turkcell, Bosch."}
            };
        }

        public void Add(Instructor instructor)
        {
            _instructors.Add(instructor);
        }

        public void Delete(Instructor instructorId)
        {

            var instructorToRemove = _instructors.SingleOrDefault(c => c.InstructorId.Equals(instructorId));
            if (instructorToRemove != null)
            {
                _instructors.Remove(instructorToRemove);
            }
        }

        public List<Instructor> GetAll()
        {
            return _instructors.ToList();
        }

        public void Update(Instructor instructor)
        {
            var updateToInstructor = _instructors.SingleOrDefault(c => c.InstructorId.Equals(instructor));

            if (updateToInstructor != null)
            {
                updateToInstructor.FirstName = instructor.FirstName;
                updateToInstructor.LastName = instructor.LastName;
                updateToInstructor.Description = instructor.Description;

                Console.WriteLine("Eğitmen güncellendi : {0} {1}", updateToInstructor.FirstName, updateToInstructor.LastName);
            }
            else
            {
                Console.WriteLine("Belirtilen ID'ye sahip bir eğitmen bulunamadı.");
            }
        }
    }
}

