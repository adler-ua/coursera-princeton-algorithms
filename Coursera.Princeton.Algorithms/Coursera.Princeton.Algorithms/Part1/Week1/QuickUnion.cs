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
        private int[] _root;

        public QuickUnion(int size)
        {
            Init(size);
        }

        private void Init(int size)
        {
            this._size = size;
            _root = new int[_size];
            for(int i=0;i<_size;i++)
            {
                _root[i] = i;
            }
        }

        public bool Connected(int p, int q)
        {
            return Root(p) == Root(q);
        }

        public int[] GetIds()
        {
            return _root;
        }

        public void Union(int p, int q)
        {
            int pRoot = Root(p);
            int qRoot = Root(q);
            _root[pRoot] = _root[qRoot];
        }

        private int Root(int p)
        {
            while (p != _root[p]) p = _root[p];
            return p;
        }
    }
}
