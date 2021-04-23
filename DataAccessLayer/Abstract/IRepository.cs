using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T>
    {
        //CRUD (Create-Read-Update-Delete)
        List<T> List();
        void Insert(T p);
        void Delete(T p);
        void Update(T p);

        // Şartlı Listeleme 
        List<T> List(Expression<Func<T, bool>> filter);
    }
}
