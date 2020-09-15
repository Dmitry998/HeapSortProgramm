using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapSort
{
    class Graph
    {
        private List<Vertex> vertices;
        private List<Rib> ribs;
        private int[] arrayView;

        public Graph(List<Vertex> vertices, List<Rib> ribs)
        {
            this.vertices = vertices;
            this.ribs = ribs;
            arrayView = ArrayView();
        }

        public int [] GetArrayView
        {
            get { return arrayView; }
        }

        public int[] ArrayView()
        {
            arrayView = new int[vertices.Count];
            for (int i = 0; i < vertices.Count; i++)
            {
                arrayView[i] = vertices[i].Weight;
            }
            return arrayView;
        }

        public List<Vertex> GetVertices { get { return vertices; } }
        public List<Rib> GetRibs { get { return ribs; } }
    }
}
