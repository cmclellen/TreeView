using CompanyABC.TreeView.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyABC.TreeView.Web.Factories
{
    public class RepositoryFactory : IRepositoryFactory
    {
        public RepositoryFactory(StructureMap.IContext ctx)
        {
            this.Context = ctx;
        }

        private StructureMap.IContext Context { get; set; }

        public T GetRepository<T>() where T : IRepository
        {
            var repository = Context.GetInstance<T>();
            return repository;
        }
    }
}
