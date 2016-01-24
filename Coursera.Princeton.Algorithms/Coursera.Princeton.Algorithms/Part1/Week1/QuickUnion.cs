using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursera.Princeton.Algorithms.Part1.Week1
{
    public class QuickUnion : IUnionFind
    {
        private int _size;
        private int[] _ids;

        public QuickUnion(int size)
        {
            Init(size);
        }

        private void Init(int size)
        {
            this._size = size;
            _ids = new int[_size];
            for(int i=0;i<_size;i++)
            {
                _ids[i] = i;
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
            _ids[pRoot] = _ids[qRoot];
        }

        private int Root(int p)
        {
            while (p != _ids[p]) p = _ids[p];
            return p;
        }
    }
}
