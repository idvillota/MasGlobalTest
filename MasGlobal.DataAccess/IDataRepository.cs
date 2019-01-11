using System;
using System.Collections.Generic;
using System.Text;

namespace MasGlobal.DataAccess
{
    public interface IDataRepository<TEntity>
    {
        IEnumerable<TEntity> GetAll();

        TEntity GetById(int Id);

        void Add(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);
    }
}
