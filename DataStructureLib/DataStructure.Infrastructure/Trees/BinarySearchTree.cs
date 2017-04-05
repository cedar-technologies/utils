using System;
using System.Collections.Generic;
using DataStructure.Infrastructure.Assets;

namespace DataStructure.Infrastructure.Trees
{
    public class BinarySearchTree<T>
    {
        private BinaryTreeNode<T> _root;
        private Comparer<T> _comparer;

        private BinarySearchTree(BinaryTreeNode<T> root, Comparer<T> comparer)
        {
            if (root == null) throw new ArgumentNullException("root");
            _root = root;
            _comparer = comparer;
        }

        public static BinarySearchTree<T> Create(T data, Comparer<T> comparer)
        {
            var root = new BinaryTreeNode<T>(data);
            return new BinarySearchTree<T>(root, comparer);
        }


        public bool Contains(T data)
        {
            var current = _root;

            while (current != null)
            {
                var result = _comparer.Compare(current.Data, data);

                if (result == 0)
                    return true;

                current = result > 0 ? current.Right : current.Left;
            }

            return false;
        }

        public List<BinaryTreeNode<T>> PreorderTraversal()
        {
            var result = new List<BinaryTreeNode<T>>();
            PreorderTraversal(_root, ref result);
            return result;
        }

        private void PreorderTraversal(BinaryTreeNode<T> current, ref List<BinaryTreeNode<T>> result)
        {
            if (current != null)
            {
                result.Add(current);
                PreorderTraversal(current.Left, ref result);
                PreorderTraversal(current.Right, ref result);
            }
        }

        public List<BinaryTreeNode<T>> InOrderTraversal()
        {
            var result = new List<BinaryTreeNode<T>>();
            InOrderTraversal(_root, ref result);
            return result;
        }

        private void InOrderTraversal(BinaryTreeNode<T> current, ref List<BinaryTreeNode<T>> result)
        {
            if (current != null)
            {
                InOrderTraversal(current.Left, ref result);
                result.Add(current);
                InOrderTraversal(current.Right, ref result);
            }
        }

        public List<BinaryTreeNode<T>> PostOrderTraversal()
        {
            var result = new List<BinaryTreeNode<T>>();
            PostOrderTraversal(_root, ref result);
            return result;
        }

        private void PostOrderTraversal(BinaryTreeNode<T> current, ref List<BinaryTreeNode<T>> result)
        {
            if (current != null)
            {
                PostOrderTraversal(current.Right, ref result);
                result.Add(current);
                PostOrderTraversal(current.Left, ref result);
            }
        }
    }
}