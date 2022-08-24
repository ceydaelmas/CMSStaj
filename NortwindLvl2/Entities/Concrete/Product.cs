using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

//veritabanına karşılık gelen nesneleri yapılandırdığımız yer.
//ör: nortwind veri tabanında ürünler tablosu varsa buna karşılık ürünler nesnesi olacak.
//Dto: data transformation object. (iki tablonun joini sonucunda ortaya çıkan obje.Entity katmanına konulur.

namespace Entities.Concrete
{
    public class Product : IEntity
    {
        public int ProductId { get; set; }
        public int CategoryID { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit{ get; set; }
        public short UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
