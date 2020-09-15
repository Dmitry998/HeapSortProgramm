using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapSort
{
    class Vertex
    {
        private int posX;
        private int posY;
        private int index;
        private int weight;

        public Vertex(int index, int weight, int x, int y)
        {
            this.index = index;
            this.weight = weight;
            posX = x;
            posY = y;
        }

        public int X { get { return posX; } }
        public int Y { get { return posY; } }
        public int Index { get { return index; } }
        public int Weight { get { return weight; } }
    }
}
