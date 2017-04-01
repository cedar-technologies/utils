using System;
using DataStructure.Infrastructure.Assets;
using DataStructure.Infrastructure.Trees;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructure.Infrastructure.Test.Trees
{
    [TestClass]
    public class Create
    {
        [TestMethod]
        public void CreateBinaryTree()
        {

            var data = new DateTime(2017,1,1);

            var binaryTree = BinaryTree<DateTime>.Create(data);

            binaryTree.Root.AddRightNeighbour(new BinaryTreeNode<DateTime>(new DateTime(2001,1,1)));
            binaryTree.Root.AddLeftNeighbour(new BinaryTreeNode<DateTime>(new DateTime(2012,1,1)));
            binaryTree.Root.Right.AddRightNeighbour(new BinaryTreeNode<DateTime>(new DateTime(2005, 1, 1)));

            Assert.IsTrue(binaryTree.Root.Right.Right.Data.Year == 2005);
            Assert.IsTrue(binaryTree.Root.Right.Data.Day == 1);
            Assert.IsTrue(binaryTree.Root.Left.Data.Year == 2012);
            Assert.IsNull(binaryTree.Root.Left.Left);

        }
    }
}
