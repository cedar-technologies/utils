using System;
using System.Collections;
using System.Collections.Generic;
using DataStructure.Infrastructure.Assets;

namespace DataStructure.Infrastructure.Trees
{
    public abstract class BinaryTree<TNode, T> : IEnumerable<T> where TNode : BinaryTreeNode<T> where T : IComparable<T> 
    {

        protected TNode _root;
        protected int _count;

        public TNode Root
        {
            get
            {
                return _root;
            }
        }

        public int Count
        {
            get
            {
                return _count;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        protected BinaryTree(TNode root)
        {
            if (root == null) throw new ArgumentNullException("root");
            _root = root;
        }

        public bool Contains(T data)
        {
            var current = _root;

            while (current != null)
            {
                var result = data.CompareTo(current.Data);
                if (result == 0) return true;
                current = result > 0 ? (TNode)current.Right : (TNode)current.Left;
            }

            return false;
        }


        public void Clear()
        {
            _root = null;
            _count = 0;
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            foreach (var binaryTreeNode in _root.PostOrderTraversal())
            {
                yield return binaryTreeNode.Data;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (var binaryTreeNode in _root.PostOrderTraversal())
            {
                yield return binaryTreeNode.Data;
            }
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            _root.PostOrderTraversal().ForEach(node =>
            {
                array.SetValue(node, arrayIndex);
                arrayIndex++;
            });
        }


    }
}