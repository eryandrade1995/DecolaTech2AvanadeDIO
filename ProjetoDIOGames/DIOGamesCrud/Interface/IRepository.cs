using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIOGames.Interface
{
    public interface IRepository<T>
    {

        List<T> Listt();
        T RetornId(int id);
        void Insert(T entity);
        void Delete(int id);
        void Update(int id, T entity);
        int NextId();

    }
}
