using System.Collections.Generic;
using System.Data.Entity;
using System;
using System.Linq;

namespace Proje.API
{
    public class Repository<T> : IRepository<T> where T : class
    {
        DataContext context = new DataContext();
        DbSet<T> _object;
        public int Delete(T p)
        {
            _object.Remove(p);
            return context.SaveChanges();
        }

        public T Find(int id)
        {
            _object.Find(id);
            return _object.Find(id);
        }

        public int Find(T p)
        {
            throw new NotImplementedException();
        }

        public T Find()
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            _object.Find(id);
            return _object.Find(id);
        }
        public int Insert(T p)
        {
            _object.Add(p);
            return context.SaveChanges();
        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public int Update()
        {
            return context.SaveChanges();
        }
    }
}
