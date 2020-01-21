using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnvironmentOverview.Model.Interfaces
{
    interface IRepository<T>
    {
        public void Create(T t);
        public void Update(T t);
        public void Delete(T t);
        public T GetById(int id);
        public List<T> GetAll();
    }
}
