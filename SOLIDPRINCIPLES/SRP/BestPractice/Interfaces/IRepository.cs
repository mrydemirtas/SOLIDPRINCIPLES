using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPRINCIPLES.SRP.BestPractice.Interfaces
{
    public interface IRepository<T>
    {
        void Insert(T entity);
        void Delete(int id);
    }
}
