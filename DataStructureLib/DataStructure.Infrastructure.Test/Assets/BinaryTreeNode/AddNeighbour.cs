using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructure.Infrastructure.Assets;

namespace DataStructure.Infrastructure.Test.Assets.BinaryTreeNode
{
    [TestClass]
    public class AddNeighbour
    {
        [TestMethod]
        public void AddLeftNeighbour()
        {
            var binaryTreeNode = new BinaryTreeNode<string>("root");
            var binaryLeftTreeNode = new BinaryTreeNode<string>("left");
            binaryTreeNode.AddLeftNeighbour(binaryLeftTreeNode);
            Assert.IsTrue(binaryTreeNode.Left == binaryLeftTreeNode);
        }

        [TestMethod]
        public void AddRightNeighbour()
        {
            var binaryTreeNode = new BinaryTreeNode<string>("root");
            var binaryRightTreeNode = new BinaryTreeNode<string>("right");
            binaryTreeNode.AddRightNeighbour(binaryRightTreeNode);
            Assert.IsTrue(binaryTreeNode.Right == binaryRightTreeNode);
        }

        [TestMethod]
        public void ReplaceLeftNeighbour()
        {
            var binaryTreeNode = new BinaryTreeNode<string>("root");
            var binaryLeftTreeNode = new BinaryTreeNode<string>("left");
            binaryTreeNode.AddLeftNeighbour(binaryLeftTreeNode);
            var binaryReplaceTreeNode = new BinaryTreeNode<string>("replace");
            binaryTreeNode.AddLeftNeighbour(binaryReplaceTreeNode);
            Assert.IsTrue(binaryTreeNode.Left == binaryReplaceTreeNode);
        }

        [TestMethod]
        public void ReplaceRightNeighbour()
        {
            var binaryTreeNode = new BinaryTreeNode<string>("root");
            var binaryRightTreeNode = new BinaryTreeNode<string>("right");
            binaryTreeNode.AddRightNeighbour(binaryRightTreeNode);
            var binaryReplaceTreeNode = new BinaryTreeNode<string>("replace");
            binaryTreeNode.AddRightNeighbour(binaryReplaceTreeNode);
            Assert.IsTrue(binaryTreeNode.Right == binaryReplaceTreeNode);
        }

        [TestMethod]
        public void DeleteLeftNeighbour()
        {
            var binaryTreeNode = new BinaryTreeNode<string>("root");
            var binaryLeftTreeNode = new BinaryTreeNode<string>("left");
            binaryTreeNode.AddLeftNeighbour(binaryLeftTreeNode);
            binaryTreeNode.RemoveLeftNeighbour();
            Assert.IsNull(binaryTreeNode.Left);
        }

        [TestMethod]
        public void RemoveRigthNeighbour()
        {
            var binaryTreeNode = new BinaryTreeNode<string>("root");
            var binaryRightTreeNode = new BinaryTreeNode<string>("right");
            binaryTreeNode.AddRightNeighbour(binaryRightTreeNode);
            binaryTreeNode.RemoveRightNeighbour();
            Assert.IsNull(binaryTreeNode.Right);
        }

        [TestMethod]
        public void GetNullLeftNeighbour()
        {
            var binaryTreeNode = new BinaryTreeNode<string>("root");
            Assert.IsNull(binaryTreeNode.Left);
        }

        [TestMethod]
        public void GetNullRigthNeighbour()
        {
            var binaryTreeNode = new BinaryTreeNode<string>("root");
            Assert.IsNull(binaryTreeNode.Right);
        }

    }
}
