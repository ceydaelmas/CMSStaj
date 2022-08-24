using Core.DataAccess.Abstract;
using Core.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.Concrete.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class,new()
        where TContext : DbContext, new()//db context implementeasyonu olmalı. kısıtlamış oluyruz.
        //context entity clası ile veri tabanını map eden bir ef yapısı.veri tabanı ile bağlantı sağlar
    {
        //burayı doldurcaz ve bu kodları bir yerde yazmamıza gerek kalmaz
        public void Add(TEntity entity)
        {
            using(TContext context=new TContext())
            {
                var addedEntity = context.Entry(entity);//entityi contexte bağladım
                addedEntity.State = EntityState.Added;//alacağı aksiyon insert
                context.SaveChanges();//veri tabanına commit ediyoruz.
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();//veri tabanına commit ediyoruz.
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
                //bana single bir eleman çekecek
            }
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter ==null? //yani id yoksa tümünü listele
                    context.Set<TEntity>().ToList():
                    context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;//pkya bakp değerleri günceller
                context.SaveChanges();//veri tabanına commit ediyoruz.
            }
        }
    }
}
