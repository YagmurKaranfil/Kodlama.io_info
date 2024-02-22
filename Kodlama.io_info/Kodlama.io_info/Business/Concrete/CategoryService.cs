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
    public class CategoryService :ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryService(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Add(Category category)
        {
            _categoryDal.Add(category);
        }

        public void Delete(Category categoryId)
        {
            _categoryDal.Delete(categoryId);
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }

        public void Update(Category category)
        {
           _categoryDal.Update(category);
        }
    }
}
