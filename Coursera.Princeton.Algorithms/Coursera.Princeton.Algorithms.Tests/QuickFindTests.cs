using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Coursera.Princeton.Algorithms.Part1.Week1;

namespace Coursera.Princeton.Algorithms.Tests
{
    [TestClass]
    public class QuickFindTests
    {
        [TestMethod]
        public void InitWorks()
        {
            IUnionFind uf = new QuickFind(10);
            int[] ids = uf.GetIds();
            for(int i=0;i<10;i++)
            {
                Assert.AreEqual(i, ids[i]);
            }
        }

        [TestMethod]
        public void DemoTest()
        {
            IUnionFind uf = new QuickFind(10);
            uf.Union(4, 3);
            int[] ids = uf.GetIds();
            Assert.AreEqual(3, ids[3]);
            Assert.AreEqual(3, ids[4]);

            uf.Union(3, 8);
            ids = uf.GetIds();
            Assert.AreEqual(8, ids[3]);
            Assert.AreEqual(8, ids[4]);

            uf.Union(6, 5);
            ids = uf.GetIds();
            Assert.AreEqual(5, ids[5]);
            Assert.AreEqual(5, ids[6]);

            uf.Union(9, 4);
            ids = uf.GetIds();
            Assert.AreEqual(8, ids[4]);
            Assert.AreEqual(8, ids[9]);

            uf.Union(2, 1);
            ids = uf.GetIds();
            Assert.AreEqual(1, ids[1]);
            Assert.AreEqual(1, ids[2]);

            Assert.IsTrue(uf.Connected(8,9));
            Assert.IsFalse(uf.Connected(5, 0));

            uf.Union(5, 0);
            ids = uf.GetIds();
            Assert.AreEqual(0, ids[0]);
            Assert.AreEqual(0,ids[5]);
            Assert.AreEqual(0, ids[6]);

            uf.Union(7, 2);
            ids = uf.GetIds();
            Assert.AreEqual(1, ids[1]);
            Assert.AreEqual(1, ids[2]);
            Assert.AreEqual(1, ids[7]);

            uf.Union(6, 1);
            ids = uf.GetIds();
            Assert.AreEqual(1, ids[0]);
            Assert.AreEqual(1, ids[1]);
            Assert.AreEqual(1, ids[2]);
            Assert.AreEqual(8, ids[3]);
            Assert.AreEqual(8, ids[4]);
            Assert.AreEqual(1, ids[5]);
            Assert.AreEqual(1, ids[6]);
            Assert.AreEqual(1, ids[7]);
            Assert.AreEqual(8, ids[8]);
            Assert.AreEqual(8, ids[9]);
        }
    }
}
