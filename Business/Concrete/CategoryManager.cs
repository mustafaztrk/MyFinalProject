using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        //veri tabanına baglılıgı azaltmak için yapıcı methoda enjekte ettim

        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()//hepsini al
        {
            //iş kodları
            return _categoryDal.GetAll();
        }

        //Select * from Categories where CategoryId=3
        public Category GetById(int categoryId)//koşulu saglayanları al
        {
            return _categoryDal.Get(c => c.CategoryId == categoryId);
        }
    }
}
