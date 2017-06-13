using System;

namespace DataStructure.Infrastructure.Assets
{

    public enum RedBlackBinaryTreeNodeColor
    {
        Black = 0,
        Red = 1
    }

    public class RebBlackBinaryTreeNode<T> : BinaryTreeNode<T> where T: IComparable<T>
    {

        private Enum _color;

        public Enum Color
        {
            get { return _color; }
        }

        public RebBlackBinaryTreeNode(T data) : base(data)
        {
            _color = RedBlackBinaryTreeNodeColor.Red;
        }

        public RebBlackBinaryTreeNode(T data, BinaryTreeNode<T> left, BinaryTreeNode<T> right) : base(data, left, right)
        {
            _color = RedBlackBinaryTreeNodeColor.Red;
        }

        public void TurnBlack()
        {
            _color = RedBlackBinaryTreeNodeColor.Red;
        }

        public void TurnRed()
        {
            _color = RedBlackBinaryTreeNodeColor.Black;
        }
    }
}