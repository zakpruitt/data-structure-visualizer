using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Msagl.Drawing;
using Microsoft.Msagl.GraphViewerGdi;


namespace Data_Structure_Visualizer
{
    public class Stack<T>
    {
        public class Node
        {
            public Node next;
            public T data;

            public Node(T data)
            {
                this.data = data;
                next = null;
                /* 
                    since next is initially set to null, when we loop 
                    through the stack, we can just view if the current 
                    node is null, rather than the next node.
                */
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

        //top of stack
        private Node top = null;
        private Node found = null;

        public bool IsEmpty()
        {
            /* 
                with how this implementation works, if top is null, this means 
                nothing is connected, as top always holds a value.
            */

            if (top == null)
                return true;
            else
                return false;
        }

        public int Size()
        {
            /*
                loops through stack, checking if the current node is null or not.
                if null, terminates loop, if not, display data. 
            */

            Node temp = top;
            int size = 0;

            while (temp != null)
            {
                temp = temp.next;
                size += 1;
            }

            return size;
        }

        public void Push(T data)
        {
            /*
                pushes all nodes down one, while making the new node the
                new top of the stack. if top is null, assigns newNode to
                the top.
            */

            Node newNode = new Node(data);

            if (top == null)
            {
                top = newNode;
            }
            else if (Contains(data) == true)
            {
                found = null;
                throw new Exception("Value already exists within Stack.");
            }
            else
            {
                Node temp = top;

                top = newNode;
                newNode.next = temp;
            }
        }

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

            while (temp != null)
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

        public T Pop()
        {
            /*
                pops top off and returns its value. sets next element as new top.
                if top.next is null, sets new top to null.
            */

            try
            {
                if (top == null)
                    throw new Exception("Stack is empty.");

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

        public T Peek()
        {
            return top.data;
        }

        public void Print()
        {
            /*
                simple method for printing out stack.
            */

            Node temp = top;
            Console.Write("START -> ");

            while (temp != null)
            {
                Console.Write(temp.data + " -> ");
                temp = temp.next;
            }

            Console.Write("END");
            Console.WriteLine(" ");
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

            try
            {
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
                        continue;
                    }

                    graph.AddEdge(previous.ToString(), element.ToString());
                    graph.FindNode(element.ToString()).Attr.FillColor = Color.LightBlue;
                    graph.FindNode(element.ToString()).Attr.Shape = Shape.Circle;

                    previous = element;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Stack cleared/or empty.");
            }

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

        public void Clear()
        {
            top = null;
        }
    }
}
