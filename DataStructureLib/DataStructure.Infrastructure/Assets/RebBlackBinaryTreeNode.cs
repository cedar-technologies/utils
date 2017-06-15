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

        public RebBlackBinaryTreeNode(T data) : base(data)
        {
        }

        public RebBlackBinaryTreeNode(T data, BinaryTreeNode<T> left, BinaryTreeNode<T> right) : base(data, left, right)
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