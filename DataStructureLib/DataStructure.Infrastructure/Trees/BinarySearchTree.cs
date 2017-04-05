using System;
using System.Collections.Generic;
using DataStructure.Infrastructure.Assets;

namespace DataStructure.Infrastructure.Trees
{
    public class BinarySearchTree<T> where T : IComparable<T>
    {
        private BinaryTreeNode<T> _root;
        private int _count;

        private BinarySearchTree(BinaryTreeNode<T> root)
        {
            if (root == null) throw new ArgumentNullException("root");
            _root = root;
            _count++;
        }

        public static BinarySearchTree<T> Create(T data)
        {
            var root = new BinaryTreeNode<T>(data);
            return new BinarySearchTree<T>(root);
        }

        public void Add(T data)
        {
            
            var node = new BinaryTreeNode<T>(data);

            if (_count == 0)
            {
                _count++;
                _root = node;
                return;
            }

            int result = 0;

            BinaryTreeNode<T> currentNode = _root;
            BinaryTreeNode<T> parent = null;

            while (currentNode != null)
            {
                result = data.CompareTo(currentNode.Data);

                if(result == 0) return;

                parent = currentNode;
                currentNode = result > 0 ? currentNode.Right : currentNode.Left;
               
            }
            
            _count++;

            if (result > 0)
            {
                parent.AddRightNeighbour(node);
            }
            else
            {
                parent.AddLeftNeighbour(node);
            }
           


        }

        public bool Contains(T data)
        {
            var current = _root;

            while (current != null)
            {
                var result =  data.CompareTo(current.Data);
                
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