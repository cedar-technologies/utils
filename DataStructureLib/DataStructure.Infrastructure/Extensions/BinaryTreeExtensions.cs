using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using DataStructure.Infrastructure.Assets;

namespace DataStructure.Infrastructure.Trees
{
    public static class BinaryTreeExtensions
    {

        public static List<BinaryTreeNode<T>> PreOrderTraversal<T>(this BinaryTreeNode<T> current)
        {
            var result = new List<BinaryTreeNode<T>>();
            PreOrderTraversal(current, result);
            return result;
        }

        private static void PreOrderTraversal<T>(BinaryTreeNode<T> current, List<BinaryTreeNode<T>> result)
        {
            if (current != null)
            {
                result.Add(current);
                PreOrderTraversal(current.Left, result);
                PreOrderTraversal(current.Right, result);
            }
        }

        private static List<BinaryTreeNode<T>> InOrderTraversal<T>(BinaryTreeNode<T> current)
        {
            var result = new List<BinaryTreeNode<T>>();
            InOrderTraversal(current, result);
            return result;
        }

        private static void InOrderTraversal<T>(BinaryTreeNode<T> current, List<BinaryTreeNode<T>> result)
        {
            if (current != null)
            {
                InOrderTraversal(current.Left, result);
                result.Add(current);
                InOrderTraversal(current.Right, result);
            }
        }

        public static List<BinaryTreeNode<T>> PostOrderTraversal<T>(this BinaryTreeNode<T> current)
        {
            var result = new List<BinaryTreeNode<T>>();
            PostOrderTraversal(current, result);
            return result;
        }

        private static void PostOrderTraversal<T>(BinaryTreeNode<T> current, List<BinaryTreeNode<T>> result)
        {
            if (current != null)
            {
                PostOrderTraversal(current.Right, result);
                result.Add(current);
                PostOrderTraversal(current.Left, result);
            }
        }
    }
}