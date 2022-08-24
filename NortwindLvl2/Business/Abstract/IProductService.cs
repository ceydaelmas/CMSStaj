using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    //repositorynin iş katmanında yeri yokkk.
    public interface IProductService
    {
        //hangi operasyonlar kullanılcaksa yazılır.

        List<Product> GetAll();
        List<Product> GetByCategory(int categoryId);

    }
}
