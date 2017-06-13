using System;
using System.Collections;
using System.Collections.Generic;
using DataStructure.Infrastructure.Assets;

namespace DataStructure.Infrastructure.Trees
{
    public abstract class BinaryTree<T> : IEnumerable<T> where T : IComparable<T>
    {

        protected BinaryTreeNode<T> _root;
        protected int _count;

        public BinaryTreeNode<T> Root
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

        protected BinaryTree(BinaryTreeNode<T> root)
        {
            if (root == null) throw new ArgumentNullException("root");
            _root = root;
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