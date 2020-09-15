using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapSort
{
    class Rib
    {
        private Vertex firstVertex;
        private Vertex secondVertex;

        public Rib(Vertex firstVertex, Vertex secondVertex)
        {
            this.firstVertex = firstVertex;
            this.secondVertex = secondVertex;
        }

        public Vertex GetFirstVertex { get { return firstVertex; } }
        public Vertex GetFSecondVertex { get { return secondVertex; } }
    }
}
