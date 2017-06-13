using System;
using System.Collections;

namespace DataStructure.Infrastructure.Trees
{
    public class RedBlackBinarySearchTree<T> : ICollection where T : IComparable<T>
    {
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public int Count { get; }
        public object SyncRoot { get; }
        public bool IsSynchronized { get; }
    }
}