using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HeapSort
{
    public partial class Form1 : Form
    {

        bool flag = false;
        bool deleteV = false;
        Graph graph;
        List<Vertex> vertices = new List<Vertex>();
        List<Rib> ribs = new List<Rib>();
        int indexVertex = 0;
        int weightVertex = 0;
        int[] graphArray = { 10, 21, 30, 7, 8, 9, 15 };
        Heap heap;

        public Form1()
        {
            InitializeComponent();
            buttonCreateVertex.Click += ButtonCreateVertex_Click;
            buttonConvertToHeap.Click += ButtonConvertToHeap_Click;
            buttonSort.Click += ButtonSort_Click;
            buttonDeleteVertex.Click += ButtonDeleteVertex_Click;
            buttonSaveGraph.Click += ButtonSaveGraph_Click;
            buttonLoadGraph.Click += ButtonLoadGraph_Click;
            startSheet.MouseClick += StartSheet_MouseClick;

        }

        private void ButtonLoadGraph_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = " |*.graph";
            List<string> numbers = new List<string>();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap bitmap = new Bitmap(resultSheet.Width, resultSheet.Height);

                StreamReader streamReader = new StreamReader(openFileDialog.OpenFile());
                string strArray = streamReader.ReadLine();
                int[] graphArray = strArray.Split(';').Select(x => int.Parse(x)).ToArray();

                vertices = new List<Vertex>();
                ribs = new List<Rib>();
                int[] posX = { 130, 70, 190, 40, 100, 160, 220, 25, 55, 85, 115, 145, 175, 205, 235 };
                int[] posY = { 40, 80, 80, 120, 120, 120, 120, 200, 200, 200, 200, 200, 200, 200, 200 };

                for (int i = 0; i < graphArray.Length; i++)
                {
                    vertices.Add(new Vertex(i, graphArray[i], posX[i], posY[i]));
                    AddRib(ribs, vertices, i);
                }
                graph = new Graph(vertices, ribs);
                indexVertex = vertices.Count;
                DrawGraph drawGraph = new DrawGraph(graph, bitmap);
                drawGraph.DrawAllGraph();
                startSheet.Image = bitmap;

                streamReader.Dispose();
                streamReader.Close();
            }
            

        }

        private void ButtonSaveGraph_Click(object sender, EventArgs e)
        {
            if (graph != null && graph.GetVertices.Count > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Title = "Сохранить граф";
                saveFileDialog.OverwritePrompt = true;
                saveFileDialog.CheckPathExists = true;
                saveFileDialog.Filter = " |*.graph";
                saveFileDialog.ShowHelp = true;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter writer = new StreamWriter(saveFileDialog.OpenFile());

                    for (int i = 0; i < graph.GetArrayView.Length; i++)
                    {
                        if (i != graph.GetArrayView.Length - 1)
                        {
                            writer.Write(graph.GetArrayView[i].ToString() + ';');
                        }
                        else
                            writer.Write(graph.GetArrayView[i].ToString());
                    }
                    writer.Dispose();
                    writer.Close();
                }
            }
            else
            {
                const string message = "Нечего сохранять.";
                const string caption = "Ошибка!";
                var messageMaxCountVertex = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonDeleteVertex_Click(object sender, EventArgs e)
        {
            deleteV = true;
            flag = false;

        }

        private void ButtonSort_Click(object sender, EventArgs e)
        {
            int[] sortArray;
            ButtonConvertToHeap_Click(sender,e);
            if (graph != null && graph.GetVertices.Count > 0)
            {
                sortArray = heap.HeapSort(graph.GetArrayView);
                textBoxArraySort.Text = null;
                for (int i = sortArray.Length - 1; i >= 0; i--)
                {
                    textBoxArraySort.Text += sortArray[i] + " ";
                }
            }
        }

        private void ButtonCreateVertex_Click(object sender, EventArgs e)
        {
            flag = true;
            deleteV = false;
        }

        private void ButtonConvertToHeap_Click(object sender, EventArgs e)
        {
            if (graph != null && graph.GetVertices.Count > 0)
            {
                heap = new Heap(graph);

                Bitmap bitmap = new Bitmap(resultSheet.Width, resultSheet.Height);

                List<Vertex> vertices = new List<Vertex>();
                List<Rib> ribs = new List<Rib>();

                int[] posX = { 130, 70, 190, 40, 100, 160, 220, 25, 55, 85, 115, 145, 175, 205, 235 };
                int[] posY = { 40, 80, 80, 120, 120, 120, 120, 200, 200, 200, 200, 200, 200, 200, 200 };

                textBoxArrayHeap.Text = null;
                for (int i = 0; i < heap.GetListHeap.Count; i++)
                {
                    vertices.Add(new Vertex(i, heap.GetListHeap[i], posX[i], posY[i]));
                    textBoxArrayHeap.Text += heap.GetListHeap[i].ToString() + " ";
                    AddRib(ribs, vertices, i);
                }

                Graph heapGraph = new Graph(vertices, ribs);
                DrawGraph drawHeapGraph = new DrawGraph(heapGraph, bitmap);
                drawHeapGraph.DrawAllGraph();
                resultSheet.Image = bitmap;
            }
            else
            {
                const string message = "Создайте хотя бы одну вершину для преобразования графа в кучу.";
                const string caption = "Ошибка!";
                var messageMaxCountVertex = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void AddRib(List<Rib> ribs,List<Vertex> vertices, int indexVertex)
        {
            if (indexVertex != 0)
            {
                if (indexVertex % 2 == 0)
                {
                    ribs.Add(new Rib(vertices[indexVertex], vertices[(indexVertex - 2) / 2]));
                }
                else
                    ribs.Add(new Rib(vertices[indexVertex], vertices[(indexVertex - 1) / 2]));
            }
        }

        private void StartSheet_MouseClick(object sender, MouseEventArgs e)
        {
            if (flag)
            {
                if (e.Button == MouseButtons.Left && indexVertex <= 14)
                {
                    try
                    {
                        weightVertex = Convert.ToInt32(textboxWeightVertex.Text);
                    }
                    catch (Exception ex)
                    {
                        Random random = new Random();
                        weightVertex = random.Next(0, 100);
                    }

                    vertices.Add(new Vertex(indexVertex, weightVertex, e.X, e.Y));
                    AddRib(ribs,vertices, indexVertex);
                    indexVertex++;
                }
                else if (indexVertex > 14)
                {
                    const string message = "Уже размещено максимальное количество вершин.";
                    const string caption = "Внимание!";
                    var messageMaxCountVertex = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (deleteV)
            {
                bool hitVertex = false;
                Vertex deleteVertex = null;
                if (e.Button == MouseButtons.Left)
                {
                    foreach (Vertex vertex in vertices)
                    {
                        if (Math.Pow(vertex.X -e.X,2) + Math.Pow(vertex.Y - e.Y,2)<=Math.Pow(DrawGraph.Radius,2))
                        {
                            deleteVertex = vertex;
                            hitVertex = true;
                            break;
                        }
                    }
                    if (hitVertex)
                    {
                        indexVertex = deleteVertex.Index;
                        vertices.RemoveAll(vertex => vertex.Index > deleteVertex.Index);
                        ribs.RemoveAll(rib => rib.GetFirstVertex.Index == deleteVertex.Index || rib.GetFSecondVertex.Index == deleteVertex.Index || rib.GetFirstVertex.Index > deleteVertex.Index || rib.GetFSecondVertex.Index > deleteVertex.Index);
                        vertices.Remove(deleteVertex);
                    }
                }
            }



            Bitmap bitmap = new Bitmap(startSheet.Width, startSheet.Height);
            graph = new Graph(vertices, ribs);
            DrawGraph drawGraph = new DrawGraph(graph, bitmap);
            drawGraph.DrawAllGraph();
            startSheet.Image = bitmap;

            graphArray = graph.GetArrayView;

            textBoxArrayViewGraph.Text = null;
            for (int i = 0; i < graphArray.Length; i++)
            {
                textBoxArrayViewGraph.Text += graphArray[i].ToString() + " ";
            }
        }

    }

}
