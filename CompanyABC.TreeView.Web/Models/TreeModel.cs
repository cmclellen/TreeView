using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompanyABC.TreeView.Web.Models
{
    public class TreeModel
    {
        public int Depth { get; set; }

        public IList<DAL.Domain.TreeNode> TreeData { get; set; }
    }
}