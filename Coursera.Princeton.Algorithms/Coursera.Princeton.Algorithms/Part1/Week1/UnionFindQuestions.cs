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

        public string Question2Seed532465()
        {
            throw new NotImplementedException();
        }

        public string Question3Seed175515()
        {
            throw new NotImplementedException();
        }
    }
}
