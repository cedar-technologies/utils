using System;
using System.IO;
using DataStructure.Infrastructure.Trees;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructure.Infrastructure.Test.Trees.BinaryTree
{
    [TestClass]
    public class Clear
    {
        [TestMethod]
        public void ItShouldClearTheBinaryTree()
        {

            var binaryTree = BinaryTree<FileInfo>.Create(new FileInfo("myFile.txt"));
            Assert.IsNotNull(binaryTree.Root);

            binaryTree.Clear();
            Assert.IsNull(binaryTree.Root);
            
        }
    }
}
