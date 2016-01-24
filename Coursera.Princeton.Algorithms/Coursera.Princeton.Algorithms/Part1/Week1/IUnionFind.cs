using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursera.Princeton.Algorithms.Part1.Week1
{
    public interface IUnionFind
    {
        int[] GetIds();

        void Union(int p, int q);
        bool Connected(int p, int q);
    }
}
