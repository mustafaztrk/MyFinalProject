using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();//Tüm ürünleri listeliyecek ortam

        List<Product> GetAllByCategoryId(int id);
        List<Product> GetByUnitPrice(decimal min,decimal max);



    }
}
