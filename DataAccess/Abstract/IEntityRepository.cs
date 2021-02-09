using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //generic constraint
    //class : referans tip 
    //IEntity : IEntityolabilir veya IEntity implement eden bir nesne olabilir
    //new() :new'lenebilir olamalıdır. IEntity soyut nesnesini gönderimini engellemek için.
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);//İstenen verilerin getirilmesi için
        T Get(Expression<Func<T, bool>> filter); //verilerden secilen bir tanesinin gelmesi icin
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity); 
    }
}
