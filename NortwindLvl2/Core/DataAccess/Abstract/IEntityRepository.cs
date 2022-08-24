using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.Abstract
{
    public interface IEntityRepository<T>//generic tip
    {
        //mesela ekleme silme güncelleme listeleme yapıcaksan sadece nesne değişiyor böyle olunca 
        //ayrı ayrı yazmaya gerek yok repository pattern var.temel operasyonları generic şekilde yazıp ortak kullanma.
        List<T> GetList(Expression<Func<T,bool>> filter=null);//delege c#. lambda denilen geçer
        T Get(Expression<Func<T, bool>> filter);
        //default null verilmez. data çekeceksem ıd verilmesi beklenir.

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
