using System;
using System.Collections;
using System.Collections.Generic;
using DataStructure.Infrastructure.Assets;

namespace DataStructure.Infrastructure.Trees
{
    public class RedBlackBinarySearchTree<T> : ICollection<T> where T : IComparable<T>
    {

        private BinaryTreeNode<T> _root;
        private int _count;

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(T item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public int Count { get; }
        public bool IsReadOnly { get; }
    }
}