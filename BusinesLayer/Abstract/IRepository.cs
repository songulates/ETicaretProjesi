using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesLayer.Abstract
{
    public interface IRepository<T> where T:class, new()
    {
        List<T> GetList();
        void Insert(T p);
        void Delete(T p);
        void Update(T p);
        T GetById(int id);
    }
}
