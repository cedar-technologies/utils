using System;
using DataStructure.Infrastructure.Trees;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructure.Infrastructure.Test.Trees.BinaryTree
{
    [TestClass]
    public class Delete
    {
        [TestMethod]
        public void it_should_delete_a_node()
        {
            var data = new DateTime(2017, 1, 1);

            var binaryTree = BinarySearchTree<DateTime>.Create(data);

            binaryTree.Add(new DateTime(2001, 1, 1));
            binaryTree.Add(new DateTime(2012, 1, 1));
            binaryTree.Add(new DateTime(2005, 1, 1));
            binaryTree.Add(new DateTime(2001, 1, 11));
            binaryTree.Add(new DateTime(1999, 1, 13));
            binaryTree.Add(new DateTime(2005, 1, 4));
            binaryTree.Add(new DateTime(2012, 2, 1));
            binaryTree.Add(new DateTime(2023, 1, 1));
            binaryTree.Add(new DateTime(2002, 1, 1));
            binaryTree.Add(new DateTime(2005, 2, 1));

            Assert.IsTrue(binaryTree.Remove(new DateTime(2005, 1, 1)));
            Assert.IsTrue(binaryTree.Remove(new DateTime(2012, 2, 1)));

            Assert.IsFalse(binaryTree.Contains(new DateTime(2005, 1, 1)));
            Assert.IsTrue(binaryTree.Contains(new DateTime(1999, 1, 13)));
            Assert.IsTrue(binaryTree.Contains(new DateTime(2002, 1, 1)));
        }


    }
}