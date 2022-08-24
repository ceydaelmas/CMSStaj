using Core.DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Abstract
{
    //veri tabanı işleri yapılan yer.insert update delete select...
    //bu katmanda loglama vs yapılmaz temel sorgulama yapılır. Burada amaç veri tabanına ulaşmak

    public interface IProductDal : IEntityRepository<Product>
    {
        //burada veri tabanında yapmak istenilen operasyonlar olur(list,ekleme vs vs)
        //bu interface old. için imza implementasyonnu concrete kısmında yaparız.
       

    }
}
