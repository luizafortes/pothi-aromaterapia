using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        void Insert(T _model);
        void Update(int _id, T _model);
        void Delete(int _id);
        List<T> GetAll();
        T GetById(int _id);
    }
}
