using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeapSort
{
    class DrawGraph
    {
        private Graph graph;
        private Bitmap bitmap;
        private Pen pen;
        private Font font;
        private Graphics graphics;
        private static int radius = 15;

        public DrawGraph(Graph graph, Bitmap bitmap)
        {
            this.graph = graph;
            this.bitmap = bitmap;
            pen = new Pen(Color.Black);
            font = new Font("Arial", 10);
            graphics = Graphics.FromImage(bitmap);
        }

        public static int Radius { get { return radius; } }

        private void DrawVertices()
        {
            foreach (Vertex vertex in graph.GetVertices)
            {
                graphics.FillEllipse(Brushes.White, (vertex.X - radius), (vertex.Y - radius), 2 * radius, 2 * radius);
                graphics.DrawEllipse(pen, (vertex.X - radius), (vertex.Y - radius), 2 * radius, 2 * radius);
                Point pointIndex = new Point(vertex.X - 18, vertex.Y - 30);
                Point pointWeight = new Point(vertex.X - 9, vertex.Y - 9);

                graphics.DrawString(vertex.Index.ToString(), font, Brushes.Black, pointIndex);
                graphics.DrawString(vertex.Weight.ToString(), font, Brushes.Black, pointWeight);
            }
        }

        private void DrawRibs()
        {
            foreach (Rib rib in graph.GetRibs)
            {
                graphics.DrawLine(pen, rib.GetFirstVertex.X, rib.GetFirstVertex.Y, rib.GetFSecondVertex.X, rib.GetFSecondVertex.Y);
            }
        }

        public void DrawAllGraph()
        {
            DrawRibs();
            DrawVertices();
        }
    }
}
