using System.Collections.Generic;

namespace Proje.API
{
    public interface IRepository<T> where T : class
    {
        int Insert(T p);
        int Update();
        int Delete(T p);
        int Find(T p);
        T Find();
        List<T> List();
        T GetById(int id);
    }
}