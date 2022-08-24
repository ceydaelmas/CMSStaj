using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Category : IEntity {
        //Ientity ile bunu bir veritabanı nesnesi olduğunu anlatmak gerekiyor.
        //yani IEntity implementasyonu olan nesne verş tabanında tablodur.
        //Dto veri tabanı nesnesi değil join nesnesi o yüzden başka implementasyonu olur.
        //bu interfaceleri corea koymak mantıklı çünkü tüm projelerde kullancam
    
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
