using System;
using System.Collections;
using System.Collections.Generic;
using DataStructure.Infrastructure.Assets;

namespace DataStructure.Infrastructure.Trees
{
    public class RedBlackBinarySearchTree<T> : BinaryTree<RebBlackBinaryTreeNode<T>, T>, ICollection<T> where T : IComparable<T>
    {
        public RedBlackBinarySearchTree(RebBlackBinaryTreeNode<T> root) : base(root)
        {
        }

        public static RedBlackBinarySearchTree<T> Create(T data)
        {
            var root = new RebBlackBinaryTreeNode<T>(data);
            return new RedBlackBinarySearchTree<T>(root);
        }

        public void Add(T item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }
    }
}