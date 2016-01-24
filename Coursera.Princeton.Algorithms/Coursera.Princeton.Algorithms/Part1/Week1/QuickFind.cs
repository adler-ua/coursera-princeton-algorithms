using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursera.Princeton.Algorithms.Part1.Week1
{
    public class QuickFind : IUnionFind
    {
        private int _size;
        private int[] _id;

        public QuickFind(int size)
        {
            Init(size);
        }

        private void Init(int size)
        {
            this._size = size;
            _id = new int[size];
            for (int i = 0; i < _size; i++)
            {
                _id[i] = i;
            }
        }

        public int[] GetIds()
        {
            return _id;
        }

        public void Union(int p, int q)
        {
            if (_id[p] == _id[q])
                return;
            int id_p = _id[p];
            for (int i=0;i<_size;i++)
            {
                if(_id[i] == id_p)
                    _id[i] = _id[q];
            }
        }

        public bool Connected(int p, int q)
        {
            return _id[p] == _id[q];
        }
    }
}
