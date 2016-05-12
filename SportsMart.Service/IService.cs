using SportsMart.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SportsMart.Services
{
    public interface IService<T>
    {
        Task<int> Create(T t);
        Task<IEnumerable<T>> FindAll();
        Task<T> FindById(int id);
    }
}
