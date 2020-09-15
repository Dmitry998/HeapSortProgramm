using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapSort
{
    class Heap
    {
        private List<int> listHeap;
        private Graph graph;

        public Heap(Graph graph)
        {
            BuildHeap(graph.GetArrayView);
        }

        public int HeapSize
        {
            get { return listHeap.Count; }
        }

        public List<int> GetListHeap { get { return listHeap; } }

        public void BuildHeap(int [] sourceArray)
        {
            listHeap = sourceArray.ToList();
            for (int i = HeapSize / 2; i >= 0; i--)
            {
                Heapify(i);
            }
        }

        public void Heapify(int index) // Свойство кучи
        {
            int leftChild;
            int rightChild;
            int largeChild;

            for (; ; )
            {
                leftChild = 2 * index + 1;
                rightChild = 2 * index + 2;
                largeChild = index;

                if (leftChild < HeapSize && listHeap[leftChild] > listHeap[largeChild])
                {
                    largeChild = leftChild;
                }

                if (rightChild < HeapSize && listHeap[rightChild] > listHeap[largeChild])
                {
                    largeChild = rightChild;
                }

                if (largeChild == index)
                {
                    break;
                }

                int temp = listHeap[index];
                listHeap[index] = listHeap[largeChild];
                listHeap[largeChild] = temp;
                index = largeChild;
            }
        }

        private int GetMax()
        {
            int max = listHeap[0];
            listHeap[0] = listHeap[HeapSize - 1];
            listHeap.RemoveAt(HeapSize - 1);
            return max;
        }

        public int [] HeapSort(int [] sourceArray)
        {
            BuildHeap(sourceArray);
            for (int i = sourceArray.Length - 1; i >=0; i--)
            {
                sourceArray[i] = GetMax();
                Heapify(0);
            }
            return sourceArray;
        }
    }
}
