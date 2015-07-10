using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyABC.TreeView.DAL.Repositories
{
    public interface IRepository
    {

    }

    public interface IRepository<TEntity> : IRepository
    {
        IList<TEntity> GetAll();
    }
}
