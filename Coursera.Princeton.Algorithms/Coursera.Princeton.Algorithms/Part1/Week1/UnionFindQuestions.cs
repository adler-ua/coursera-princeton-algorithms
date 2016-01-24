using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursera.Princeton.Algorithms.Part1.Week1
{
    public class UnionFindQuestions
    {
        public static string Question1Seed341498()
        {
            IUnionFind uf = new QuickFind(10);
            uf.Union(0, 4);
            uf.Union(3, 6);
            uf.Union(0,8);
            uf.Union(2,6);
            uf.Union(1,4);
            uf.Union(4,9);
            int[] ids = uf.GetIds();
            string res = string.Join(" ", ids);
            return res;
        }

        public static string Question2Seed532465()
        {
            IUnionFind uf = new WeightedQuickUnion(10);
            //9-7 2-0 0-7 5-1 1-6 3-5 1-4 5-2 8-6 
            uf.Union(9, 7);
            uf.Union(2, 0);
            uf.Union(0, 7);
            uf.Union(5, 1);
            uf.Union(1, 6);
            uf.Union(3, 5);
            uf.Union(1, 4);
            uf.Union(5, 2);
            uf.Union(8, 6);
            int[] ids = uf.GetIds();
            string res = string.Join(" ", ids);
            return res;
        }

        public string Question3Seed175515()
        {
            throw new NotImplementedException();
        }
    }
}
