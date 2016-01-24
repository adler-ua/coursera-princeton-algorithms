using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursera.Princeton.Algorithms.Part1.Week1
{
    public class WellWeightedQuickUnion : IUnionFind
    {
        private int[] _ids;
        private int[] _size;

        public WellWeightedQuickUnion(int size)
        {
            Init(size);
        }

        private void Init(int size)
        {
            _ids = new int[size];
            _size = new int[size];
            for(int i=0;i< size;i++)
            {
                _ids[i] = i;
                _size[i] = 1;
            }
        }

        public bool Connected(int p, int q)
        {
            return Root(p) == Root(q);
        }

        public int[] GetIds()
        {
            return _ids;
        }

        public void Union(int p, int q)
        {
            int pRoot = Root(p);
            int qRoot = Root(q);
            if (_size[qRoot] > _size[pRoot])
            {
                _ids[pRoot] = _ids[qRoot];
                _size[qRoot] += _size[pRoot];
            }
            else
            {
                _ids[qRoot] = _ids[pRoot];
                _size[pRoot] += _size[qRoot];
            }
        }

        private int Root(int p)
        {
            while (p != _ids[p]) p = _ids[p];
            return p;
        }
    }
}
