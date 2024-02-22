using Kodlama.io_info.Business.Concrete;
using Kodlama.io_info.DataAccess.Concrete;
using Kodlama.io_info.Entities.Concrete;
using System.Diagnostics;

namespace Kodlama.io_info
{
    public class Program
    {
        static void Main(string[] args)
        {
            CategoryService categoryService = new CategoryService(new CategoryDal());
            CourseService courseService = new CourseService(new CourseDal());
            InstructorService ınstructorService = new InstructorService(new InstructorDal());

            int select, select2;


            Console.WriteLine("1- Kategori işlemleri ");
            Console.WriteLine("2- Kurs işlemleri");
            Console.WriteLine("3- Eğitmen işlemleri \n");


            Console.WriteLine("İşlem yapmak istediğiniz alanı seçin \n");
            select = Convert.ToInt32(Console.ReadLine());

            if (select == 1)
            {
                Console.Write("Yapmak istediğiniz işlemi seçin \n");
                Crud();

                select2 = Convert.ToInt32(Console.ReadLine());

                List<Category> categories = categoryService.GetAll();
                if (select2 == 1)
                {

                    foreach (var category in categories)
                    {
                        Console.WriteLine(
                            $"Kategori Id: {category.CategoryId}," +
                            $"Kategori Adı: {category.CategoryName}");
                    }

                }
                else if (select2 == 2)
                {

                    categoryService.Add(new Category
                    {
                        CategoryId = 4,
                        CategoryName = "Web Programlama"
                    });

                    Console.WriteLine("Kategori başarıyla eklendi.");

                }
                else if (select2 == 3)
                {
                    categoryService.Delete(new Category
                    {
                        CategoryId = 4
                    }); ;
                    Console.WriteLine("Kategori başarıyla silindi.");

                }
                else if (select2 == 4)
                {
                    categoryService.Update(new Category
                    {
                        CategoryId = 4,
                        CategoryName = "Siber Güvenlik"
                    });
                }
                else
                {
                    Console.WriteLine("Yanlış seçim yaptınız tekrar deneyin");
                    Crud();
                }
                Console.ReadLine();

            }

            //------------------------------------------------

            if (select == 2)
            {
                Console.Write("Yapmak istediğiniz işlemi seçin \n");
                Crud();

                select2 = Convert.ToInt32(Console.ReadLine());

                List<Course> courses = courseService.GetAll();
                if (select2 == 1)
                {

                    foreach (var course in courses)
                    {
                        Console.WriteLine(
                        $"Kurs Id: {course.CourseId}," +
                        $"Kategori Id: {course.CategoryId}," +
                        $"Eğitmen Id: {course.InstructorId}," +
                        $"Kurs Adı: {course.CourseName}," +
                        $"Açıklama: {course.Description}," +
                        $"Ücret: {course.Price}"
                        );
                    }

                }
                else if (select2 == 2)
                {

                    courseService.Add(new Course
                    {
                        CourseId = 8,
                        CategoryId = 2,
                        InstructorId = 2,
                        CourseName = "Mobil Programlama",
                        Description = "Sıfırdan başlıyoruz",
                        Price = 0
                    });

                    Console.WriteLine("Kurs başarıyla eklendi.");

                }
                else if (select2 == 3)
                {
                    courseService.Delete(new Course
                    {
                        CourseId = 8
                    }); ;
                    Console.WriteLine("Kurs başarıyla silindi.");

                }
                else if (select2 == 4)
                {
                    courseService.Update(new Course
                    {
                        CourseId = 8,
                        CategoryId = 2,
                        InstructorId = 2,
                        CourseName = "Siber güvenlik",
                        Description = "Sıfırdan başlıyoruz",
                        Price = 0
                    });
                }
                else
                {
                    Console.WriteLine("Yanlış seçim yaptınız tekrar deneyin");
                    Crud();
                }


                //-----------------------------------------------

                if (select == 3)
                {
                    Console.Write("Yapmak istediğiniz işlemi seçin \n");
                    Crud();

                    select2 = Convert.ToInt32(Console.ReadLine());

                    List<Instructor> instructors = ınstructorService.GetAll();
                    if (select2 == 1)
                    {

                        foreach (var instructor in instructors)
                        {
                            Console.WriteLine(
                            $"Eğitmen Id: {instructor.InstructorId}," +
                            $"Eğitmen Adı: {instructor.FirstName}," +
                            $"Eğitmen Soyadı: {instructor.LastName}," +
                            $"Açıklama: {instructor.Description},"
                            );
                        }

                    }
                    else if (select2 == 2)
                    {

                        ınstructorService.Add(new Instructor
                        {
                            InstructorId = 3,
                            FirstName = "Melike",
                            LastName = "Şahin",
                            Description = "3 yıldır bu işi yapıyorum",

                        });

                        Console.WriteLine("Eğitmen başarıyla eklendi.");

                    }
                    else if (select2 == 3)
                    {
                        ınstructorService.Delete(new Instructor
                        {
                            InstructorId = 3
                        }); ;
                        Console.WriteLine("Eğitmen başarıyla silindi.");

                    }
                    else if (select2 == 4)
                    {
                        ınstructorService.Update(new Instructor
                        {
                            InstructorId = 3,
                            FirstName = "Ayşe",
                            LastName = "Kara",
                            Description = "Yeni başladım",
                        });
                    }
                    else
                    {
                        Console.WriteLine("Yanlış seçim yaptınız tekrar deneyin");
                        Crud();
                    }


                    Console.ReadLine();

                }


            }

            static void Crud()
            {
                Console.WriteLine("1- Verileri listele");
                Console.WriteLine("2- Veri ekle");
                Console.WriteLine("3- Veriyi sil");
                Console.WriteLine("4- Veriyi güncelle");
                Console.WriteLine(" ");
            }
        }
    }
}
