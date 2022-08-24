using Business.Abstract;
using DataAcces.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    //iş kurallarını ve ona konu olan clasları yönetir
    public class ProductManager : IProductService
    {
        //buradda data acces katmanını kullancam yanı Efproductdal
        //new yaparsam sonra dappera geçsem sıkıntı olur bağımlılıkları sınıflamak gerek. entityframeworke dair bir şey olmamalı.
        private IProductDal _producDal;
       
        public ProductManager(IProductDal producDal)
        {
            _producDal = producDal;   
            //biz productmanager newlediğimiz zaman ona i product türünde instance vereceğiz bu dapper olabilir ef olabilir.
            //Dependency injection.
        }

        public List<Product> GetAll()
        {
            return _producDal.GetList();
        }

        public List<Product> GetByCategory(int categoryId)
        {
            return _producDal.GetList(p => p.CategoryID == categoryId);
        }
    }
}
