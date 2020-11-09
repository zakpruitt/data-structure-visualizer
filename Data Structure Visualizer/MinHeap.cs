using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Msagl.Drawing;
using Microsoft.Msagl.GraphViewerGdi;

namespace Data_Structure_Visualizer
{
    public class MinHeap<T> where T : IComparable
    {
        private List<T> elements = new List<T>();

        // GETTER METHODS
        public T GetMin()
        {
            return elements.Count > 0 ? elements[0] : default;
        }

        private int GetParent(int index)
        {
            if (index <= 0)
            {
                return -1;
            }

            return (index - 1) / 2;
        }

        private int GetLeft(int index)
        {
            return 2 * index + 1;
        }

        private int GetRight(int index)
        {
            return 2 * index + 2;
        }

        // ACTION METHODS
        public void Add(T data)
        {
            elements.Add(data);
            HeapifyUp(elements.Count - 1);
        }

        public T PopMin()
        {
            if (elements.Count > 0)
            {
                T item = elements[0];
                elements[0] = elements[elements.Count - 1];
                elements.RemoveAt(elements.Count - 1);

                HeapifyDown(0);
                return item;
            }

            throw new InvalidOperationException("No elements remaining in MinHeap.");
        }

        // re-creates elements into a heap structure
        private void HeapifyUp(int index)
        {
            var parent = GetParent(index);
            if (parent >= 0 && elements[index].CompareTo(elements[parent]) < 0)
            {
                var temp = elements[index];
                elements[index] = elements[parent];
                elements[parent] = temp;

                HeapifyUp(parent);
            }
        }

        private void HeapifyDown(int index)
        {
            var smallest = index;

            var left = GetLeft(index);
            var right = GetRight(index);

            if (left < elements.Count && elements[left].CompareTo(elements[index]) < 0)
            {
                smallest = left;
            }

            if (right < elements.Count && elements[right].CompareTo(elements[smallest]) < 0)
            {
                smallest = right;
            }

            if (smallest != index)
            {
                var temp = elements[index];
                elements[index] = elements[smallest];
                elements[smallest] = temp;

                HeapifyDown(smallest);
            }

        }

        public void Draw(Panel graph_panel)
        {
            // create objects
            GViewer viewer = new GViewer();
            Graph graph = new Graph("graph");

            //graph.LayoutAlgorithmSettings = new Microsoft.Msagl.Layout.Incremental.;
            Node root = new Node(GetMin().ToString());

            if (GetMin() == null) 
            { 
                // do nothing. bind blank graph to viewer. 
            }
            else
                DrawHeap(graph);


            // bind the graph to the viewer 
            viewer.Graph = graph;

            // associate the viewer with the form 
            graph_panel.SuspendLayout();
            graph_panel.Controls.Clear();

            // viewer settings
            viewer.OutsideAreaBrush = System.Drawing.Brushes.White;
            viewer.LayoutAlgorithmSettingsButtonVisible = false;
            viewer.EdgeInsertButtonVisible = false;
            viewer.UndoRedoButtonsVisible = false;
            viewer.NavigationVisible = false;

            // link to panel
            graph_panel.Controls.Add(viewer);
            graph_panel.ResumeLayout();
            graph_panel.Show();
        }

        public void DrawHeap(Graph graph)
        {
            int parentIndex = 0;
            int iterationIndex = 0;

            while (iterationIndex < elements.Count)
            {
                if (parentIndex == 0 && iterationIndex == 0)
                {
                    var root = graph.AddNode(elements[0].ToString());
                    root.Attr.FillColor = Color.LightSeaGreen;
                    root.Attr.Shape = Shape.Circle;
                    iterationIndex += 1;
                    continue;
                }

                graph.AddEdge(elements[parentIndex].ToString(), elements[iterationIndex].ToString());
                var node = graph.FindNode(elements[iterationIndex].ToString());
                node.Attr.FillColor = Color.LightGray;
                node.Attr.Shape = Shape.Circle;

                if (iterationIndex % 2 == 0)
                    parentIndex += 1;

                iterationIndex += 1;
            }                
        }
    }
}
