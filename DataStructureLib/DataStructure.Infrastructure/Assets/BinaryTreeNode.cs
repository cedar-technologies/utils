using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Infrastructure.Assets
{
    public class BinaryTreeNode<T> : Node<T>
    {
        public BinaryTreeNode(T data) : base(data)
        {
        }

        public new BinaryTreeNode<T> Parent
        {
            get { return (BinaryTreeNode<T>) base.Parent; }
            set { base.Parent = value; }
        }

        public BinaryTreeNode<T> Left
        {
            get { return (BinaryTreeNode<T>)base.GetNeighbours().ElementAtOrDefault(0); }
        }

        public BinaryTreeNode<T> Right
        {
            get { return (BinaryTreeNode<T>)base.GetNeighbours().ElementAtOrDefault(1); }
        }

        public void AddLeftNeighbour(BinaryTreeNode<T> neigbour)
        {
            AddNeighbourAt(neigbour, 0);
        }

        public void AddRightNeighbour(BinaryTreeNode<T> neighbour)
        {
            if(GetNeighbours().Count == 0)
                AddNeighbourAt(null, 0);
            AddNeighbourAt(neighbour, 1);
        }

        public void RemoveLeftNeighbour()
        {
            RemoveNeighbourAt(0);
        }

        public void RemoveRightNeighbour()
        {
            RemoveNeighbourAt(1);
        }



    }
}
