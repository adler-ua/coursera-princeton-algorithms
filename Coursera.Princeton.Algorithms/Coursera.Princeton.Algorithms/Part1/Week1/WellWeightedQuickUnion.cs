using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursera.Princeton.Algorithms.Part1.Week1
{
    public class WellWeightedQuickUnion : IUnionFind
    {
        private int _size;
        private int[] _root;
        private int[] _rootsize;

        public WellWeightedQuickUnion(int size)
        {
            Init(size);
        }

        private void Init(int size)
        {
            _size = size;
            _root = new int[_size];
            _rootsize = new int[_size];
            for(int i=0;i< _size;i++)
            {
                _root[i] = i;
                _rootsize[i] = 1;
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
            if (_rootsize[qRoot] > _rootsize[pRoot])
            {
                _root[pRoot] = _root[qRoot];
                _rootsize[qRoot] += _rootsize[pRoot];
            }
            else
            {
                _root[qRoot] = _root[pRoot];
                _rootsize[pRoot] += _rootsize[qRoot];
            }
        }

        private int Root(int p)
        {
            while (p != _root[p]) p = _root[p];
            return p;
        }
    }
}
