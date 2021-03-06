﻿using System.Linq;

namespace DataStructure.Infrastructure.Assets
{
    public class BinaryTreeNode<T> : Node<T>
    {
        public BinaryTreeNode(T data) : base(data)
        {
        }

        public BinaryTreeNode(T data, BinaryTreeNode<T> left, BinaryTreeNode<T> right) : this (data)
        {
            AddNeighbour(left);
            AddNeighbour(right);
        }

        public BinaryTreeNode<T> Left
        {
            get { return (BinaryTreeNode<T>) base.GetNeighbours().ElementAtOrDefault(0); }
        }

        public BinaryTreeNode<T> Right
        {
            get { return (BinaryTreeNode<T>) base.GetNeighbours().ElementAtOrDefault(1); }
        }

        public void AddLeftNeighbour(BinaryTreeNode<T> neigbour)
        {
            AddNeighbourAt(neigbour, 0);
        }

        public void AddRightNeighbour(BinaryTreeNode<T> neighbour)
        {
            AddNeighbourAt(neighbour, 1);
        }

        public void RemoveLeftNeighbour()
        {
            RemoveNeighbourAt(0);
        }

        public void RemoveRightNeighbour()
        {
            RemoveNeighbourAt(1);
        }



    }
}