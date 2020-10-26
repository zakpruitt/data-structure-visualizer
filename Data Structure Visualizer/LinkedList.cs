using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Msagl.Drawing;
using Microsoft.Msagl.GraphViewerGdi;

namespace Data_Structure_Visualizer
{
    public class LinkedList<T> where T : IComparable<T>
    {
        public class Node
        {
            public Node next;
            public T data;

            public override string ToString()
            {
                if (next == null)
                {
                    return $"Node with a data value of {data} and next value being null.";
                }
                else
                {
                    return $"Node with a data value of {data} and next value being {next.data}.";
                }
                
            }
        }

        private Node head;
        private Node found = null;

        public LinkedList()
        {
            head = new Node(); // just points to next node, so it does not have a value.
        }

        public void InsertHeadNode(T headValue)
        {
            Node temp = head.next; //saves next node to be pointed to

            Node newNode = new Node();
            newNode.data = headValue;
            head.next = newNode;

            head.next.next = temp; // points to saved node
        }

        public void InsertTailNode(T tailValue)
        {
            Node temp = head;

            while (temp.next != null)
            {
                temp = temp.next;
            }

            Node newNode = new Node();
            newNode.data = tailValue;

            temp.next = newNode;
        }

        public T RemoveHeadNode()
        {
            T data = head.next.data;
            head.next = head.next.next; //skips head.next; therefore, removing it

            return data;
        }

        public T RemoveTailNode()
        {
            Node temp = head;

            while (temp.next.next != null)
            {
                temp = temp.next;
            }

            T data = temp.next.data;
            temp.next = null; //nulls tail node

            return data;
        }

        public bool IsEmpty()
        {
            if (head.next == null)
                return true;
            else
                return false;
        }

        public void PrintAllNodes()
        {
            Console.Write("Head -> ");
            Node temp = head;

            while (temp.next != null)
            {
                temp = temp.next;
                Console.Write(temp.data + " -> ");
            }
            Console.Write("NULL");
            Console.WriteLine(" ");
        }

        public void InsertAfter(int position, T value)
        {
            // must select from 1 - the range of the linked list.
            Node temp = head;
            int counter = 0;

            try
            {
                while (temp.next != null)
                {
                    temp = temp.next;
                    counter++;

                    if (counter == position)
                        break;
                }

                if (position > counter)
                    throw new Exception("Position out of range");

                Node newNode = new Node();
                newNode.data = value;

                Node saved = temp.next;
                temp.next = newNode; //links new node to first half of list.

                newNode.next = saved; //links newest node to other half of list.

            }
            catch (Exception ex)
            {
                Console.WriteLine("\nException caught: {0}.", ex.Message);
            }

        }

        public void RemoveAfter(int position)
        {
            // must select from 1 - the range of the linked list.
            Node temp = head;
            int counter = 0;

            try
            {
                while (temp.next != null)
                {
                    temp = temp.next;
                    counter++;

                    if (counter == position)
                        break;
                }

                if (position > counter)
                    throw new Exception("Position out of range");

                Node saved = temp.next.next;
                temp.next = saved;
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nException caught: {0}.", ex.Message);
            }
        }

        public Node Find(T target)
        {
            Node temp = head;

            while (temp.next != null)
            {
                temp = temp.next;

                if (EqualityComparer<T>.Default.Equals(temp.data, target)) //can't perform == on T values, so must use this method to compare.
                    break;
            }

            found = temp;
            return temp;
        }

        public int GetCount()
        {
            Node temp = head;
            int count = 0;

            // gather node amount
            while (temp.next != null)
            {
                temp = temp.next;
                count++;
            }

            return count;
        }

        public void Sort()
        {
            Node temp = head;
            List<T> data = new List<T>();

            // gather numbers
            while (temp.next != null)
            {
                temp = temp.next;
                data.Add(temp.data);
            }

            temp = head; // reset head
            data = InsertionSort(data); // could just do data.Sort()

            // place numbers into LL
            for (int i = 0; i < data.Count; i++)
            {
                temp = temp.next;
                temp.data = data[i];
            }
        }

        private List<T> InsertionSort(List<T> inputList)
        {
            for (int i = 0; i < inputList.Count - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (inputList[j - 1].CompareTo(inputList[j]) > 0)
                    {
                        T temp = inputList[j - 1];
                        inputList[j - 1] = inputList[j];
                        inputList[j] = temp;
                    }
                }
            }
            return inputList;
        }

        public void Draw(Panel graph_panel)
        {
            Node temp = head;
            List<T> data = new List<T>();

            // gather numbers
            while (temp.next != null)
            {
                temp = temp.next;
                data.Add(temp.data);
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
                    continue;
                }

                viewer.CurrentLayoutMethod = LayoutMethod.Ranking;

                var edge = graph.AddEdge(previous.ToString(), element.ToString());
                edge.Attr.Length = 1;
                graph.FindNode(element.ToString()).Attr.FillColor = Color.LightBlue;
                graph.FindNode(element.ToString()).Attr.Shape = Shape.Circle;

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
