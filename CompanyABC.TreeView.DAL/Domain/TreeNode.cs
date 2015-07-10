using CompanyABC.Common.Extensions;
using CompanyABC.Common.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyABC.TreeView.DAL.Domain
{
    public class TreeNode : IEquatable<TreeNode>
    {
        IList<TreeNode> _treeNodes;

        public TreeNode(string displayText, IList<TreeNode> treeNodes = null)
        {
            Guard.NotNullOrEmpty(() => displayText, displayText);
            this.DisplayText = displayText;
            this.TreeNodes = treeNodes;
        }

        public string DisplayText { get; private set; }

        public IList<TreeNode> TreeNodes {
            get { return _treeNodes ?? (_treeNodes = new List<TreeNode>()); }
            set { _treeNodes = value; } 
        }

        public bool Equals(TreeNode other)
        {
            bool isEqual = false;
            if (other != null)
            {
                isEqual =
                    string.Equals(DisplayText, other.DisplayText) &&
                    TreeNodes.SafeSequenceEqual(other.TreeNodes);
            }
            return isEqual;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as TreeNode);
        }

        public override int GetHashCode()
        {
            return DisplayText.GetHashCode();
        }
    }
}
