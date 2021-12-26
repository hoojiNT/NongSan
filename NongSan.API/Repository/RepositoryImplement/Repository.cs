using NongSan.API.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NongSan.API.Repository
{
    public class Repository<T> : IRepository<T> where T : Base
    {
        private readonly ShopDbContext context;
        private DbSet<T> entities;
        public Repository(ShopDbContext context)
        {
            this.context = context;
            entities = context.Set<T>();
        }
        public void Delete(T entity)
        {
            if(entity == null)
            {
                throw new ArgumentNullException("Entity");
            }
            entities.Remove(entity);
            context.SaveChanges();
        }

        public T Get(string Id)
        {
            return entities.SingleOrDefault(x => x.ID == Id);
        }

        public IEnumerable<T> GetAll()
        {
            return entities.AsEnumerable();
        }

        public void Insert(T entity)
        {
            if(entity == null)
            {
                throw new ArgumentNullException("Entity");
            }
            entities.Add(entity);
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            if(entity == null)
            {
                throw new ArgumentNullException("Entity");
            }
            entities.Update(entity);
            context.SaveChanges();
        }
    }
}
