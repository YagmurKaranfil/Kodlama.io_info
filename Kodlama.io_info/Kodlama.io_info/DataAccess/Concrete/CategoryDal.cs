using Kodlama.io_info.DataAccess.Abstract;
using Kodlama.io_info.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io_info.DataAccess.Concrete
{
    public class CategoryDal : ICategoryDal
    {
        List<Category> _categories;

        public CategoryDal()
        {
            _categories = new List<Category>()
            {
                new Category{CategoryId=1 , CategoryName="Backend geliştirme"},
                new Category{CategoryId=2 , CategoryName="Frontend geliştirme"},
                new Category{CategoryId=3 , CategoryName="Test geliştirme"},
                new Category{CategoryId=4 , CategoryName="Programlamaya giriş"},
            };
        }

        public void Add(Category category)
        {
            _categories.Add(category);
        }

        public void Delete(Category categoryId)
        {

            var categoryToRemove = _categories.SingleOrDefault(c => c.CategoryId.Equals(categoryId));
            if (categoryToRemove != null)
            {
                _categories.Remove(categoryToRemove);
            }
        }


        public List<Category> GetAll()
        {
           return _categories.ToList();
        }

        public void Update(Category category)
        {
            var updateToCategory = _categories.SingleOrDefault(c => c.CategoryId.Equals(category));

            if (updateToCategory != null)
            {
       
                updateToCategory.CategoryName = category.CategoryName;

                Console.WriteLine("Kategori güncellendi:  Yeni Adı: {0}", updateToCategory.CategoryName);
            }
            else
            {
                Console.WriteLine("Belirtilen ID'ye sahip bir kategori bulunamadı.");
            }
        }
    }
}
