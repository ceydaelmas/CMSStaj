using Core.DataAccess.Concrete.EntityFramework;
using DataAcces.Abstract;
using DataAcces.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Concrete.EntityFramework
{
    public class EfProductDal :EfEntityRepositoryBase<Product,NorthwindContext>, IProductDal
        //buraya baserepo eklenince iproductdalı implemente etmeye gerek yok çünkü basede var.
    {
        
    }
}
