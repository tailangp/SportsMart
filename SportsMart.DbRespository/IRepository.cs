using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsMart.Repository
{
    public interface IRepository<T>
    {
        Task<int> Create(T t);
        Task<IEnumerable<T>> FindAll();
        Task<T> FindById(int id);
    }
}
