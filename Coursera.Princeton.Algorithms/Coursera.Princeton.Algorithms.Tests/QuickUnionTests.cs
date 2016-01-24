using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Coursera.Princeton.Algorithms.Part1.Week1;

namespace Coursera.Princeton.Algorithms.Tests
{
    [TestClass]
    public class QuickUnionTests
    {
        [TestMethod]
        public void InitWorks()
        {
            IUnionFind uf = new QuickUnion(10);
            int[] ids = uf.GetIds();
            for (int i = 0; i < 10; i++)
            {
                Assert.AreEqual(i, ids[i]);
            }
        }

        [TestMethod]
        public void DemoTest()
        {
            IUnionFind uf = new QuickUnion(10);
            uf.Union(4, 3);
            int[] root = uf.GetIds();
            Assert.AreEqual(3, root[3]);
            Assert.AreEqual(3, root[4]);

            uf.Union(3, 8);
            root = uf.GetIds();
            Assert.AreEqual(8, root[3]);

            uf.Union(6, 5);
            root = uf.GetIds();
            Assert.AreEqual(5, root[6]);

            uf.Union(9, 4);
            root = uf.GetIds();
            Assert.AreEqual(8, root[9]);

            uf.Union(2, 1);
            root = uf.GetIds();
            Assert.AreEqual(1, root[2]);

            Assert.IsTrue(uf.Connected(8, 9));
            Assert.IsFalse(uf.Connected(5, 4));

            uf.Union(5, 0);
            root = uf.GetIds();
            Assert.AreEqual(0,root[5]);

            uf.Union(7, 2);
            root = uf.GetIds();
            Assert.AreEqual(1, root[7]);

            uf.Union(6, 1);
            root = uf.GetIds();
            Assert.AreEqual(1, root[0]);

            uf.Union(7, 3);
            root = uf.GetIds();
            Assert.AreEqual(8, root[1]);

            Assert.AreEqual(1, root[0]);
            Assert.AreEqual(8, root[1]);
            Assert.AreEqual(1, root[2]);
            Assert.AreEqual(8, root[3]);
            Assert.AreEqual(3, root[4]);
            Assert.AreEqual(0, root[5]);
            Assert.AreEqual(5, root[6]);
            Assert.AreEqual(1, root[7]);
            Assert.AreEqual(8, root[8]);
            Assert.AreEqual(8, root[9]);
        }
    }
}
