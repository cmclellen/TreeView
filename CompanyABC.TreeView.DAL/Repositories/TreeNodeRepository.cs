using CompanyABC.TreeView.DAL.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyABC.TreeView.DAL.Repositories
{
    public class TreeNodeRepository : Repository<TreeNode>, ITreeNodeRepository
    {
        public TreeNodeRepository()
        {

        }

        public IList<TreeNode> GetAll()
        {
            // Hard coded data access
            return new[]{
                new TreeNode("Root", new[]{
                    new TreeNode("Folder 1", new []{
                        new TreeNode("Folder 1.1"),
                        new TreeNode("Folder 1.2")
                    }),
                    new TreeNode("Folder 2", new []{
                        new TreeNode("Folder 2.1"),
                        new TreeNode("Folder 2.2", new []{
                            new TreeNode("Folder 2.2.1"),
                            new TreeNode("Folder 2.2.2"),
                            new TreeNode("Folder 2.2.3"),
                        })
                    })
                })
            };
        }
    }
}
