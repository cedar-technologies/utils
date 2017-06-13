using System;
using System.Collections.Generic;
using DataStructure.Infrastructure.Assets;

namespace DataStructure.Infrastructure.Trees
{
    public class BinaryTree<T>
    {

        private BinaryTreeNode<T> _root;

        public BinaryTreeNode<T> Root
        {
            get
            {
                return _root;
            }
        }

        public BinaryTree(BinaryTreeNode<T> root)
        {
            if(root == null) throw new ArgumentNullException("root");
            _root = root;
        }

        public static BinaryTree<T> Create(T data)
        {
            var root = new BinaryTreeNode<T>(data);
            return new BinaryTree<T>(root);

            var list = new List<string>();

        }

        public virtual void Clear()
        {
            _root = null;
        }

    }
}