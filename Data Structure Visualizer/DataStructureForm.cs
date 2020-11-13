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
            method_ds_select.SelectedIndex = 0;

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
                    LinkedList_Methods_Change("regular");
                    break;

                case "Stack":
                    Stack_Methods_Change("regular");
                    break;

                case "Queue":
                    Queue_Methods_Change("regular");
                    break;

                case "Binary Search Tree":
                    BST_Methods_Change("regular");
                    break;

                case "Min Heap":
                    MinHeap_Methods_Change("regular");
                    break;
            }

            switch (method_ds_select.SelectedItem)
            {
                case "Linked List":
                    LinkedList_Methods_Change("docs");
                    break;

                case "Stack":
                    Stack_Methods_Change("docs");
                    break;

                case "Queue":
                    Queue_Methods_Change("docs");
                    break;

                case "Binary Search Tree":
                    BST_Methods_Change("docs");
                    break;

                case "Min Heap":
                    MinHeap_Methods_Change("docs");
                    break;
            }
        }

        private void Execute_Method_Click(object sender, EventArgs e)
        {
            dynamic data;

            try
            {
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

                    case "DeleteBNode(int target)":
                        myBST.DeleteBNode(int.Parse(first_parameter_input.Text));
                        myBST.Draw(graph_panel);
                        break;

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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Method_Docs_Change(object sender, EventArgs e)
        {
            switch (method_doc_select.SelectedItem)
            {
                case "InsertHeadNode(int data)":
                    method_description_box.Text = "Inserts a brand new node at the beginning of the Linked List; thus, the new node becomes the new head. If other nodes exist within the Linked List, they will be set as the new node's .next data member.";
                    parameter_description_box.Text = "Takes in only one parameter that will be used as the new node's data value.";
                    time_complexity_box.Text = "Since the new node is always inserted at the same space, it runs at a O(1) constant time.";
                    break;

                case "InsertTailNode(int data)":
                    method_description_box.Text = "Inserts a brand new node at the end of the Linked List; thus, the new node becomes the new tail.";
                    parameter_description_box.Text = "Takes in only one parameter that will be used as the new node's data value.";
                    time_complexity_box.Text = "Since the implementation featured here does not keep a pointer at the end of the Linked List, the time complexity is O(n). With a pointer, it is O(1), or constant.";
                    break;

                case "RemoveHeadNode()":
                    method_description_box.Text = "Removes an extant node at the beginning of the Linked List; thus, the second node in the Linked List will become the new head node. Returns removed node.";
                    parameter_description_box.Text = "Takes in no parameters.";
                    time_complexity_box.Text = "Since the removed node is always at the same space, it runs at a O(1) constant time.";
                    break;

                case "RemoveTailNode()":
                    method_description_box.Text = "Removes an extant node at the end of the Linked List; thus, shortening the Linked List by one node and setting the second-to-last node's .next value equal to null. Returns removed node.";
                    parameter_description_box.Text = "Takes in no parameters.";
                    time_complexity_box.Text = "Since the implementation featured here does not keep a pointer at the end of the Linked List, the time complexity is O(n). With a pointer, it is O(1), or constant.";
                    break;

                case "InsertAfter(int data, int position)":
                    method_description_box.Text = "Inserts a new node after a given integer position within the Linked List.";
                    parameter_description_box.Text= "The first parameter represents the new node's future value. After instantiation the new node's .data data member will be assigned this value. The second parameters represents the position one space before where the user would like to insert the new node.";
                    time_complexity_box.Text = "In its worst case, it would insert a node after the last position; therefore, the time complexity would be O(n).";
                    break;

                case "RemoveAfter(int position)":
                    method_description_box.Text = "Removes a node after a given integer position within the Linked List. Returns removed node.";
                    parameter_description_box.Text = "This method only takes in a single parameter representing the position before where the user would like to remove an extant node.";
                    time_complexity_box.Text = "In its worst case, it would remove a node after the second-to-last position; therefore, the time complexity would be O(n).";
                    break;

                case "Find(int target)":
                    method_description_box.Text = "Finds and highlights a specific node within the Linked List, then returns said node.";
                    parameter_description_box.Text = "Takes in a target integer value to find an extant node with the same value.";
                    time_complexity_box.Text = "In its worst case, it would search every node within the Linked List, making its time complexity O(n).";
                    break;

                case "Sort()":
                    method_description_box.Text = "Performs an insertion sort on each Linked List node's .data value.";
                    parameter_description_box.Text = "Takes in no parameters.";
                    time_complexity_box.Text = "Since an insertion sort requires a nested for loop, the time complexity is O(n^2).";
                    break;

                case "Push(int data)":
                    method_description_box.Text = "Inserts an item to the top of the Stack, pushing any subsquent items down in the process.";
                    parameter_description_box.Text = "Takes in one parameter to represent the new node's .data data member. After instantiation the new node's .data will be assigned to the parameter data.";
                    time_complexity_box.Text = "Since it is inserting in the same spot each time, the time complexity is O(1) constant time.";
                    break;

                case "Pop()":
                    method_description_box.Text = "Removes the top-most node and returns its value.";
                    parameter_description_box.Text = "Takes in no parameters.";
                    time_complexity_box.Text = "Since it is removing and shifting the stack in the same orientation each time, the time complexity is O(1) constant time.";
                    break;

                case "Peek()":
                    method_description_box.Text = "Returns the top-most node's value; however, the node is NOT removed (unlike Pop()).";
                    parameter_description_box.Text = "Takes in no parameters.";
                    time_complexity_box.Text = "Since it is accessing and returning a value at the same position each time, the time complexity is O(1) constant time.";
                    break;

                case "Enqueue(int data)":
                    method_description_box.Text = "Inserts a new node at the bottom of the queue.";
                    parameter_description_box.Text = "Takes in a integer value to be assigned to the new node's .data value after instantiation.";
                    time_complexity_box.Text = "With the current implementation, there is no pointer to the bottom of the queue, so the time complexity is O(n); however, if there is a pointer to the bottom of the queue, the time complexity is O(1) constant time.";
                    break;

                case "Dequeue()":
                    method_description_box.Text = "Dequeue, or removes, the top-most node from the Queue, then returns the removed node's value.";
                    parameter_description_box.Text = "Takes in no parameters.";
                    time_complexity_box.Text = "Since it is accessing and removing at the same place each time, the time complexity is O(1) constant time.";
                    break;

                case "Contains(int key)":
                    method_description_box.Text = "Finds and highlights a node within the Queue. If found, returns the node.";
                    parameter_description_box.Text = "Takes in a target integer value to find the node with the same value attached to it.";
                    time_complexity_box.Text = "In its worst case, it must iterate through the entire queue, so the time complexity is O(n).";
                    break;

                case "InsertBNode(int nodeData)":
                    method_description_box.Text = "Recursively inserts a binary tree node within the Binary Search Tree. Recursion is used at each interval to search throughout the entire tree for best placement.";
                    parameter_description_box.Text = "Takes in a data value to be assigned as the new node's value after instantiation.";
                    time_complexity_box.Text = "The Binary Search Tree's insert has a time complexity of O(h) (or n), meaning its time complexity scales with the height of the tree; however, at a best case, insertion can be as fast as O(logn).";
                    break;

                case "DeleteBNode(int target)":
                    method_description_box.Text = "Recursively deletes a binary tree node within the Binary Search Tree. Recursion is used at each interval to search throughout each branch.";
                    parameter_description_box.Text = "Takes in a data value to find an extant node with the same assigned data value. This will flag this node for deletion.";
                    time_complexity_box.Text = "The Binary Search Tree's insert has a time complexity of O(h) (or n), meaning its time complexity scales with the height of the tree; however, at a best case, removal can be as fast as O(log n).";
                    break;

                case "GetMin()":
                    method_description_box.Text = "Returns the minimum value within the MinHeap; therefore, this method just returns the root node's value.";
                    parameter_description_box.Text = "This method takes in no parameters.";
                    time_complexity_box.Text = "Since we are always accessing the node at the same location, this method runs in O(1) constant time.";
                    break;

                case "Add(int data)":
                    method_description_box.Text = "Adds a new node the Heap. This node will either be heapified down or up, so the Heap's properties can remain true.";
                    parameter_description_box.Text = "Takes in an integer value to be assigned to the new node after instantiation.";
                    time_complexity_box.Text = "The number of operations required depends only on the number of levels the new element must rise to satisfy the Heap property; thus, the insertion operation has a worst-case time complexity of O(log n).";
                    break;

                case "PopMin()":
                    method_description_box.Text = "Removes the node possessing the minimum value in the MinHeap; thus, this method removes the root node.";
                    parameter_description_box.Text = "Takes in no parameters.";
                    time_complexity_box.Text = "Since the popped value is always in the same location, the time complexity is O(1) constant time.";
                    break;
            }
        }

        private void Clear_Button_Click(object sender, EventArgs e)
        {
            switch (data_structure_select.SelectedItem)
            {
                case "Linked List":
                    myLL.Clear();
                    myLL.Draw(graph_panel);
                    break;

                case "Stack":
                    myStack.Clear();
                    myStack.Draw(graph_panel);
                    break;

                case "Queue":
                    myQueue.Clear();
                    myQueue.Draw(graph_panel);
                    break;

                case "Binary Search Tree":
                    myBST.Clear();
                    myBST.Draw(graph_panel);
                    break;

                case "Min Heap":
                    myMinHeap.Clear();
                    myMinHeap.Draw(graph_panel);
                    break;
            }
        }

        private void LinkedList_Methods_Change(string mode)
        {
            if (mode == "regular")
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
            else
            {
                method_doc_select.Items.Clear();
                method_doc_select.Items.Add("InsertHeadNode(int data)");
                method_doc_select.Items.Add("InsertTailNode(int data)");
                method_doc_select.Items.Add("RemoveHeadNode()");
                method_doc_select.Items.Add("RemoveTailNode()");
                method_doc_select.Items.Add("InsertAfter(int data, int position)");
                method_doc_select.Items.Add("RemoveAfter(int position)");
                method_doc_select.Items.Add("RemoveTailNode()");
                method_doc_select.Items.Add("Find(int target)");
                method_doc_select.Items.Add("Sort()");
            }
            
        }

        private void Stack_Methods_Change(string mode)
        {
            if (mode == "regular")
            {
                method_select.Items.Clear();
                method_select.Items.Add("Push(int data)");
                method_select.Items.Add("Pop()");
                method_select.Items.Add("Peek()");
            }
            else
            {
                method_doc_select.Items.Clear();
                method_doc_select.Items.Add("Push(int data)");
                method_doc_select.Items.Add("Pop()");
                method_doc_select.Items.Add("Peek()");
            }
        }

        private void Queue_Methods_Change(string mode)
        {
            if (mode == "regular")
            {
                method_select.Items.Clear();
                method_select.Items.Add("Enqueue(int data)");
                method_select.Items.Add("Dequeue()");
                method_select.Items.Add("Contains(int key)");
            }
            else
            {
                method_doc_select.Items.Clear();
                method_doc_select.Items.Add("Enqueue(int data)");
                method_doc_select.Items.Add("Dequeue()");
                method_doc_select.Items.Add("Contains(int key)");
            }
           
        }

        private void BST_Methods_Change(string mode)
        {
            if (mode == "regular")
            {
                method_select.Items.Clear();
                method_select.Items.Add("InsertBNode(int nodeData)");
                method_select.Items.Add("DeleteBNode(int target)");
            }
            else
            {
                method_doc_select.Items.Clear();
                method_doc_select.Items.Add("InsertBNode(int nodeData)");
                method_doc_select.Items.Add("DeleteBNode(int target)");
            }
            
        }

        private void MinHeap_Methods_Change(string mode)
        {
            if (mode == "regular")
            {
                method_select.Items.Clear();
                method_select.Items.Add("GetMin()");
                method_select.Items.Add("Add(int data)");
                method_select.Items.Add("PopMin()");
            }
            else
            {
                method_doc_select.Items.Clear();
                method_doc_select.Items.Add("GetMin()");
                method_doc_select.Items.Add("Add(int data)");
                method_doc_select.Items.Add("PopMin()");
            }
           
        }
    }
}
