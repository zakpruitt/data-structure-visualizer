using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Msagl.Drawing;
using Microsoft.Msagl.GraphViewerGdi;

namespace Data_Structure_Visualizer
{
    class Queue<T>
    {
        public class Node
        {
            public Node next;
            public T data;

            public Node(T data)
            {
                this.data = data;
                next = null;               
            }

            public override string ToString()
            {
                if (next == null)
                {
                    return $"Node with data {data} and next value being null.";
                }
                else
                {
                    return $"Node with data {data} and next value being {next.data}.";
                }

            }
        }

        //top of queue
        private Node top = null;
        private Node found = null;

        // METHODS 

        public bool Contains(T key)
        {
            if (top.next == null)
            {
                if (top.data.Equals(key))
                {
                    found = top;
                    return true;
                }
                else
                    return false;
            }

            Node temp = top;
            bool contains = false;

            while (temp.next != null)
            {
                if (temp.data.Equals(key))
                {
                    found = temp;
                    contains = true;
                }
                    
                temp = temp.next;
            }

            return contains;
        }

        public void Enqueue(T data) // adds to end of queue
        {
            if (top == null)
            {
                top = new Node(data);
                return;
            }

            Node temp = top;

            while (temp.next != null)
            {
                temp = temp.next;
            }

            temp.next = new Node(data);
        }

        public T Dequeue()
        {
            try
            {
                if (top == null)
                    throw new Exception("Stack is empty");

                T data = top.data;

                if (top.next == null)
                    top = null;
                else
                    top = top.next;

                return data;
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nException caught: {0}.", ex.Message);
                throw;
            }
        }

        public void Draw(Panel graph_panel)
        {
            Node temp = top;
            List<T> data = new List<T>();

            // gather numbers
            while (temp != null)
            {
                data.Add(temp.data);
                temp = temp.next;
            }

            // create objects
            GViewer viewer = new GViewer();
            Graph graph = new Graph("graph");

            // graph contents
            T previous = data[0];

            foreach (T element in data)
            {
                if (data[0].Equals(element))
                {
                    graph.AddNode(element.ToString());
                    Microsoft.Msagl.Drawing.Node head = graph.FindNode(element.ToString());

                    head.Attr.FillColor = Color.LightYellow;
                    head.Attr.Shape = Shape.Circle;
                }
                else if (data[data.Count - 1].Equals(element))
                {
                    graph.AddEdge(previous.ToString(), element.ToString());
                    graph.FindNode(element.ToString()).Attr.FillColor = Color.LightCoral;
                    graph.FindNode(element.ToString()).Attr.Shape = Shape.Circle;
                }
                else
                {
                    graph.AddEdge(previous.ToString(), element.ToString());
                    graph.FindNode(element.ToString()).Attr.FillColor = Color.LightBlue;
                    graph.FindNode(element.ToString()).Attr.Shape = Shape.Circle;
                }

                previous = element;
            }

            if (found != null)
            {
                var node = graph.FindNode(found.data.ToString());
                node.Attr.FillColor = Color.LightGreen;
                node.Attr.Shape = Shape.Diamond;

                found = null;
            }

            // bind the graph to the viewer 
            viewer.Graph = graph;

            // associate the viewer with the form 
            graph_panel.SuspendLayout();
            graph_panel.Controls.Clear();

            // viewer settings
            viewer.Dock = DockStyle.Fill;
            viewer.LayoutAlgorithmSettingsButtonVisible = false;
            viewer.EdgeInsertButtonVisible = false;
            viewer.UndoRedoButtonsVisible = false;
            viewer.NavigationVisible = false;

            // link to panel
            graph_panel.Controls.Add(viewer);
            graph_panel.ResumeLayout();
            graph_panel.Show();
        }
    }
}
