using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Interfaces
{
    public interface IBase<T> where T : class
    {
        bool Insert(T _model);
        void Update(int _id, T _model);
        void Delete(int _id);
        List<T> GetAll();
        T GetById(int _id);
    }
}
