using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamStore.Data
{
    public interface IRepository<T>
    {
        IQueryable<T> GetAll();
        T FindById(int id);
        Boolean Create(T TObject);
        Boolean Update(int id,T TObject);
        Boolean Delete(T TObject);
        Boolean CreateMultiple(List<T> TObjects);
    }
}
