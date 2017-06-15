using DataStructure.Infrastructure.Trees;

namespace DataStructure.Infrastructure.Assets
{
    public class RebBlackBinaryTreeNode<T> : BinaryTreeNode<T>
    {
        private NodeColor _color = NodeColor.BLACK;

        public NodeColor Color
        {
            get
            {
                return _color;
            }
        }

        public new RebBlackBinaryTreeNode<T> Parent
        {
            get { return (RebBlackBinaryTreeNode<T>) base.Parent; }
        }

        public new RebBlackBinaryTreeNode<T> Right
        {
            get { return (RebBlackBinaryTreeNode<T>)base.Right; }
        }

        public new RebBlackBinaryTreeNode<T> Left
        {
            get { return (RebBlackBinaryTreeNode<T>)base.Left; }
        }

        public RebBlackBinaryTreeNode(T data) : base(data)
        {
        }

        public void PaintInRed()
        {
            _color = NodeColor.RED;
        }

        public void PaintInBlack()
        {
            _color = NodeColor.BLACK;
        }

        public void SwtichColor()
        {
            if (_color == NodeColor.BLACK) PaintInRed(); else PaintInBlack();
        }
    }
}