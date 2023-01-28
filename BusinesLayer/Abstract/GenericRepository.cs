using DataAccesLayer.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesLayer.Abstract
{
    //GR bir t entitiy alıyo Irepodan miras al, Ireponun şartlarını yaz
    public class GenericRepository<T> : IRepository<T> where T : class, new()
    {
        DataContext context = new DataContext();
        public void Delete(T p)
        {
            context.Set<T>().Remove(p);
            context.SaveChanges();

        }

        public T GetById(int id)
        {
            return context.Set<T>().Find(id);
        }

        public List<T> GetList()
        {
            return context.Set<T>().ToList();
        }

        public void Insert(T p)
        {
            context.Set<T>().Add(p);
            context.SaveChanges();
        }

        public void Update(T p)
        {
            context.Entry<T>(p).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
