using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Coursera.Princeton.Algorithms.Part1.Week1;

namespace Coursera.Princeton.Algorithms.Tests
{
    [TestClass]
    public class WeightedQuickUnionTests
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
            IUnionFind uf = new WeightedQuickUnion(10);

            int[] root = new int[10];

            uf.Union(4, 3);
            root = uf.GetIds();
            Assert.AreEqual(4, root[3]);

            uf.Union(3, 8);
            root = uf.GetIds();
            Assert.AreEqual(4, root[8]);

            uf.Union(6, 5);
            root = uf.GetIds();
            Assert.AreEqual(6, root[5]);

            uf.Union(9, 4);
            root = uf.GetIds();
            Assert.AreEqual(4, root[9]);

            uf.Union(2, 1);
            root = uf.GetIds();
            Assert.AreEqual(2, root[1]);

            uf.Union(5, 0);
            root = uf.GetIds();
            Assert.AreEqual(6, root[0]);

            uf.Union(7, 2);
            root = uf.GetIds();
            Assert.AreEqual(2, root[7]);

            uf.Union(6, 1);
            root = uf.GetIds();
            Assert.AreEqual(6, root[2]);

            uf.Union(7, 3);
            root = uf.GetIds();
            Assert.AreEqual(6, root[4]);

            Assert.AreEqual(6, root[0]);
            Assert.AreEqual(2, root[1]);
            Assert.AreEqual(6, root[2]);
            Assert.AreEqual(4, root[3]);
            Assert.AreEqual(6, root[4]);
            Assert.AreEqual(6, root[5]);
            Assert.AreEqual(6, root[6]);
            Assert.AreEqual(2, root[7]);
            Assert.AreEqual(4, root[8]);
            Assert.AreEqual(4, root[9]);
        }
    }
}
