using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using DataStructure.Infrastructure.Assets;

namespace DataStructure.Infrastructure.Trees
{
    public class BinarySearchTree<T> : ICollection where T : IComparable<T>
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
            var result = Find(data);
            return result != null;
        }

        public BinaryTreeNode<T> Find(T data)
        {
            var current = _root;

            while (current != null)
            {
                var result = data.CompareTo(current.Data);
                if (result == 0) return current;
                current = result > 0 ? current.Right : current.Left;
            }

            return null;
            
        }

        public bool Delete(T data)
        {
            if (_root == null) return false;


            BinaryTreeNode<T> current = _root, parent = null;
            var result = data.CompareTo(current.Data);

            while (result != 0)
            {
                if (result > 0)
                {
                    parent = current;
                    current = current.Right;
                } else if (result < 0)
                {
                    parent = current;
                    current = current.Left;
                }

                if (current == null) return false;

                result = data.CompareTo(current.Data);

            }

            _count--;
            if (current.Right == null)
            {

                if(parent == null)
                {
                    _root = current.Left;
                }
                else
                {
                    result = parent.Data.CompareTo(current.Data);
                    if (result > 0)
                    {
                        parent.AddLeftNeighbour(current.Left);
                    } else if (result < 0)
                    {
                        parent.AddRightNeighbour(current.Left);
                    }

                }


            } else if (current.Right.Left == null)
            {
                current.Right.AddLeftNeighbour(current.Left);

                if (parent == null)
                {
                    _root = current.Right;
                }
                else
                {
                    result = parent.Data.CompareTo(current.Data);

                    if (result > 0)
                    {
                        parent.AddLeftNeighbour(current.Right);
                    }
                    else if (result < 0)
                    {
                        parent.AddRightNeighbour(current.Right);
                    }

                }

            }
            else
            {
                BinaryTreeNode<T> leftMost = current.Right.Left, leftMostParent = current.Right;

                while (leftMost.Left != null)
                {
                    leftMostParent = leftMost;
                    leftMost = leftMost.Left;
                }

                leftMostParent.AddLeftNeighbour(leftMost.Right);

                leftMost.AddLeftNeighbour(current.Left);
                leftMost.AddRightNeighbour(current.Right);

                if (parent == null)
                {
                    _root = leftMost;
                }
                else
                {
                    if (current.Data.CompareTo(parent.Data) > 0)
                    {
                        parent.AddRightNeighbour(leftMost);
                    }
                    else
                    {
                        parent.AddRightNeighbour(leftMost);
                    }
                }
            ;

            }

            return true;
        }

        public void Clear()
        {
            _root = null;
            _count = 0;
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void CopyTo(Array array, int index)
        {
             _root.PostOrderTraversal().ForEach(node =>
             {
                 array.SetValue(node, index);
                 index++;
             });
            
        }

        public int Count
        {
            get { return _count; }
        }

        public object SyncRoot { get; }
        public bool IsSynchronized { get; }
    }
}