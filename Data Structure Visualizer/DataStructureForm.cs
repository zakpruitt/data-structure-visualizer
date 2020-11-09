using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Xml;
using Microsoft.Msagl.Drawing;
using Microsoft.Msagl.GraphViewerGdi;

namespace Data_Structure_Visualizer
{
    public partial class Form : System.Windows.Forms.Form
    {
        // LINKED LIST-BASED DS
        LinkedList<int> myLL = new LinkedList<int>();
        Stack<int> myStack = new Stack<int>();
        Queue<int> myQueue = new Queue<int>();

        // TREE-BASED DS
        BinarySearchTree<int> myBST = new BinarySearchTree<int>();
        MinHeap<int> myMinHeap = new MinHeap<int>();

        public Form()
        {
            InitializeComponent();
            data_structure_select.SelectedIndex = 0;

            myBST.InsertBNode(5);
            myBST.InsertBNode(2);
            myBST.InsertBNode(1);
            myBST.InsertBNode(4);
            myBST.InsertBNode(3);
            myBST.InsertBNode(6);
            myBST.InsertBNode(7);

            // create objects
            GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            Graph graph = new Graph("graph");

            // sample content
            graph.AddEdge("A", "B");
            graph.AddEdge("B", "C");
            graph.AddEdge("A", "C").Attr.Color = Microsoft.Msagl.Drawing.Color.Black;

            graph.FindNode("A").Attr.FillColor = Microsoft.Msagl.Drawing.Color.LightYellow;
            graph.FindNode("A").Attr.Shape = Shape.Circle;

            graph.FindNode("B").Attr.FillColor = Microsoft.Msagl.Drawing.Color.LightBlue;
            graph.FindNode("B").Attr.Shape = Shape.Circle;

            graph.FindNode("C").Attr.FillColor = Microsoft.Msagl.Drawing.Color.LightCoral;
            graph.FindNode("C").Attr.Shape = Shape.Circle;

            // bind the graph to the viewer 
            viewer.Graph = graph;

            // associate the viewer with the form 
            graph_panel.SuspendLayout();
            graph_panel.Controls.Clear();

            // viewer settings
            viewer.Dock = DockStyle.Fill;
            viewer.OutsideAreaBrush = Brushes.White;
            viewer.LayoutAlgorithmSettingsButtonVisible = false;
            viewer.EdgeInsertButtonVisible = false;
            viewer.UndoRedoButtonsVisible = false;
            viewer.NavigationVisible = false;

            // link to panel
            graph_panel.Controls.Add(viewer);
            graph_panel.ResumeLayout();
        }

        private void Data_Structure_Changed(object sender, EventArgs e)
        {
            switch (data_structure_select.SelectedItem)
            {
                case "Linked List":
                    LinkedList_Methods_Change();
                    break;

                case "Stack":
                    Stack_Methods_Change();
                    break;

                case "Queue":
                    Queue_Methods_Change();
                    break;

                case "Binary Search Tree":
                    BST_Methods_Change();
                    break;

                case "Min Heap":
                    MinHeap_Methods_Change();
                    break;
            }
        }

        private void Execute_Method_Click(object sender, EventArgs e)
        {
            dynamic data;

            switch (method_select.SelectedItem)
            {
                case "InsertHeadNode(int data)":
                    myLL.InsertHeadNode(int.Parse(first_parameter_input.Text));
                    myLL.Draw(graph_panel);
                    break;

                case "InsertTailNode(int data)":
                    myLL.InsertTailNode(int.Parse(first_parameter_input.Text));
                    myLL.Draw(graph_panel);
                    break;

                case "RemoveHeadNode()":
                    data = myLL.RemoveHeadNode();
                    myLL.Draw(graph_panel);
                    return_box.Text = data.ToString();
                    break;

                case "RemoveTailNode()":
                    data = myLL.RemoveTailNode();
                    myLL.Draw(graph_panel);
                    return_box.Text = data.ToString();
                    break;

                case "InsertAfter(int data, int position)":
                    myLL.InsertAfter(int.Parse(second_parameter_input.Text), int.Parse(first_parameter_input.Text));
                    myLL.Draw(graph_panel);
                    break;

                case "RemoveAfter(int position)":
                    myLL.InsertAfter(int.Parse(second_parameter_input.Text), int.Parse(first_parameter_input.Text));
                    myLL.Draw(graph_panel);
                    break;

                case "Find(int target)":
                    data = myLL.Find(int.Parse(first_parameter_input.Text));
                    myLL.Draw(graph_panel);
                    return_box.Text = data.ToString();
                    break;

                case "Sort()":
                    myLL.Sort();
                    myLL.Draw(graph_panel);
                    break;

                case "Push(int data)":
                    myStack.Push(int.Parse(first_parameter_input.Text));
                    myStack.Draw(graph_panel);
                    break;

                case "Pop()":
                    data = myStack.Pop();
                    myStack.Draw(graph_panel);
                    return_box.Text = data.ToString();
                    break;

                case "Peek()":
                    data = myStack.Peek();
                    return_box.Text = data.ToString();
                    break;

                case "Enqueue(int data)":
                    myQueue.Enqueue(int.Parse(first_parameter_input.Text));
                    myQueue.Draw(graph_panel);
                    break;

                case "Dequeue()":
                    data = myQueue.Dequeue();
                    myQueue.Draw(graph_panel);
                    return_box.Text = data.ToString();
                    break;

                case "Contains(int key)":
                    data = myQueue.Contains(int.Parse(first_parameter_input.Text));
                    return_box.Text = data.ToString();
                    break;

                case "InsertBNode(int nodeData)":
                    myBST.InsertBNode(int.Parse(first_parameter_input.Text));
                    myBST.Draw(graph_panel);
                    break;

                case "FindBNode(int target)":
                    data = myBST.TreeSearch(myBST.Root, int.Parse(first_parameter_input.Text));
                    myBST.Draw(graph_panel);
                    return_box.Text = data.ToString();
                    break;

                case "DeleteBNode(int target)":
                    myBST.DeleteBNode(int.Parse(first_parameter_input.Text));
                    myBST.Draw(graph_panel);
                    break;

                //case "PreOrder()":
                //    myBST.Draw(graph_panel, "PreOrder");
                //    break;

                //case "InOrder() *default*":
                //    myBST.Draw(graph_panel, "default");
                //    break;

                //case "PostOrder()":
                //    myBST.Draw(graph_panel, "PostOrder");
                //    break;

                case "GetMin()":
                    data = myMinHeap.GetMin();
                    return_box.Text = data.ToString();
                    break;

                case "Add(int data)":
                    myMinHeap.Add(int.Parse(first_parameter_input.Text));
                    myMinHeap.Draw(graph_panel);
                    break;
                    
                case "PopMin()":
                    data = myMinHeap.PopMin();
                    myMinHeap.Draw(graph_panel);
                    return_box.Text = data.ToString();
                    break;
            }
        }
    
        private void LinkedList_Methods_Change()
        {
            method_select.Items.Clear();
            method_select.Items.Add("InsertHeadNode(int data)");
            method_select.Items.Add("InsertTailNode(int data)");
            method_select.Items.Add("RemoveHeadNode()");
            method_select.Items.Add("RemoveTailNode()");
            method_select.Items.Add("InsertAfter(int data, int position)");
            method_select.Items.Add("RemoveAfter(int position)");
            method_select.Items.Add("RemoveTailNode()");
            method_select.Items.Add("Find(int target)");
            method_select.Items.Add("Sort()");
        }

        private void Stack_Methods_Change()
        {
            method_select.Items.Clear();
            method_select.Items.Add("Push(int data)");
            method_select.Items.Add("Pop()");
            method_select.Items.Add("Peek()");
        }

        private void Queue_Methods_Change()
        {
            method_select.Items.Clear();
            method_select.Items.Add("Enqueue(int data)");
            method_select.Items.Add("Dequeue()");
            method_select.Items.Add("Contains(int key)");
        }

        private void BST_Methods_Change()
        {
            method_select.Items.Clear();
            method_select.Items.Add("InsertBNode(int nodeData)");
            method_select.Items.Add("FindBNode(int target)");
            method_select.Items.Add("DeleteBNode(int target)");
            //method_select.Items.Add("PreOrder()");
            //method_select.Items.Add("InOrder() *default*");
            //method_select.Items.Add("PostOrder()");
        }

        private void MinHeap_Methods_Change()
        {
            method_select.Items.Clear();
            method_select.Items.Add("GetMin()");
            method_select.Items.Add("Add(int data)");
            method_select.Items.Add("PopMin()");
        }
    }
}
