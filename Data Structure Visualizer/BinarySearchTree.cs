using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Msagl.Drawing;
using Microsoft.Msagl.GraphViewerGdi;

namespace Data_Structure_Visualizer
{
    class BNode<T>
    {
        private T data;
        public BNode<T> left;
        public BNode<T> right;

        public BNode(T item)
        {
            data = item;
            left = null;
            right = null;
        }

        public BNode(T item, BNode<T> leftNode, BNode<T> rightNode)
        {
            data = item;
            left = leftNode;
            right = rightNode;
        }

        public T GetData()
        {
            return data;
        }
    }

    class BinarySearchTree<T> where T : IComparable<T>
    {
        // DATA MEMBERS
        private BNode<T> root;

        // ACCESSOR
        public BNode<T> Root { get => root; }

        // METHODS

        // uses the TreeSearch() to insert a new value.
        public void InsertBNode(T nodeData)
        {
            if (root == null)
                root = new BNode<T>(nodeData);
            else
                TreeSearch(root, nodeData);
        }

        // searches for nodes and inserts node when found empty space
        public BNode<T> TreeSearch(BNode<T> vertex, T target)
        {
            if (vertex == null)
            {
                return null;
            }
            else if (vertex.GetData().CompareTo(target) == 0) // if equal
            {
                return vertex;
            }
            else if (vertex.GetData().CompareTo(target) > 0) // to left
            {
                if (vertex.left == null)
                {
                    /* 
                     * since we always pass in the value as the target we're trying to input,
                     * if we find that the vertex is going to go left or right into null, we know
                     * that we found the place where the node belongs.
                    */
                    BNode<T> newNode = new BNode<T>(target);
                    vertex.left = newNode;

                    return vertex.left;
                }

                return TreeSearch(vertex.left, target);
            }
            else // right
            {
                if (vertex.right == null)
                {
                    BNode<T> newNode = new BNode<T>(target);
                    vertex.right = newNode;

                    return vertex.right;
                }

                return TreeSearch(vertex.right, target);
            }
        }

        // recursively prints inorder tree
        public void PrintInorder(BNode<T> node)
        {
            if (node == null)
                return;

            PrintInorder(node.left);
            Console.Write(node.GetData() + " ");
            PrintInorder(node.right);
        }

        public void Draw(Panel graph_panel)
        {
            // create objects
            GViewer viewer = new GViewer();
            Graph graph = new Graph("graph");

            DrawNode(graph, root, Root.GetData().ToString());
            //graph.LayoutAlgorithmSettings = new Microsoft.Msagl.Layout.Incremental.;

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

        private void DrawNode(Graph graph, BNode<T> node, string prev)
        {
            if (node == null)
                return;

            if (node == root && graph.FindNode(root.GetData().ToString()) == null)
            {
                var root = graph.AddNode(node.GetData().ToString());
                root.Attr.FillColor = Color.LightSeaGreen;
                root.Attr.Shape = Shape.Circle;
            }
            if (node.GetData().ToString() != root.GetData().ToString())
            {
                graph.AddEdge(node.GetData().ToString(), prev);
                graph.FindNode(node.GetData().ToString()).Attr.FillColor = Color.LightGray;
                graph.FindNode(node.GetData().ToString()).Attr.Shape = Shape.Circle;
            }

            prev = node.GetData().ToString();

            DrawNode(graph, node.left, prev);
            DrawNode(graph, node.right, prev);
        }
    }
}

//using System;
//using System.Collections.Generic;
//using System.ComponentModel.Design.Serialization;
//using System.Windows.Forms;
//using Microsoft.Msagl.Drawing;
//using Microsoft.Msagl.GraphViewerGdi;

//namespace Data_Structure_Visualizer
//{
//    class BNode<T>
//    {
//        private T data;
//        public BNode<T> left;
//        public BNode<T> right;

//        public BNode(T item)
//        {
//            data = item;
//            left = null;
//            right = null;
//        }

//        public BNode(T item, BNode<T> leftNode, BNode<T> rightNode)
//        {
//            data = item;
//            left = leftNode;
//            right = rightNode;
//        }

//        public T GetData()
//        {
//            return data;
//        }
//    }

//    class BinarySearchTree<T> where T : IComparable<T>
//    {
//        // DATA MEMBERS
//        private BNode<T> root;
//        private PhyloTree tree; // for graph drawing


//        // CONSTRUCTORS
//        public BinarySearchTree() { tree = new PhyloTree(); }

//        // ACCESSOR
//        public BNode<T> Root { get => root; }

//        // METHODS

//        // uses the TreeSearch() to insert a new value.
//        public void InsertBNode(T nodeData)
//        {
//            if (root == null)
//            {
//                BNode<T> root = new BNode<T>(nodeData);
//                this.root = root;
//            }
//            else
//                TreeSearch(root, nodeData);
//        }

//        // searches for nodes and inserts node when found empty space
//        public BNode<T> TreeSearch(BNode<T> vertex, T target)
//        {
//            if (vertex == null)
//            {
//                return null;
//            }
//            else if (vertex.GetData().CompareTo(target) == 0) // if equal
//            {
//                return vertex;
//            }
//            else if (vertex.GetData().CompareTo(target) > 0) // to left
//            {
//                if (vertex.left == null)
//                {
//                    /* 
//                     * since we always pass in the value as the target we're trying to input,
//                     * if we find that the vertex is going to go left or right into null, we know
//                     * that we found the place where the node belongs.
//                    */
//                    BNode<T> newNode = new BNode<T>(target);
//                    vertex.left = newNode;

//                    return vertex.left;
//                }

//                return TreeSearch(vertex.left, target);
//            }
//            else // right
//            {
//                if (vertex.right == null)
//                {
//                    BNode<T> newNode = new BNode<T>(target);
//                    vertex.right = newNode;

//                    return vertex.right;
//                }

//                return TreeSearch(vertex.right, target);
//            }
//        }

//        // recursively prints inorder tree
//        public void PrintInorder(BNode<T> node)
//        {
//            if (node == null)
//                return;

//            PrintInorder(node.left);
//            Console.Write(node.GetData() + " ");
//            PrintInorder(node.right);
//        }

//        public void Draw(Panel graph_panel)
//        {
//            // create object
//            GViewer viewer = new GViewer();
//            DrawNode(root, root.GetData().ToString());

//            // bind graph to viewer
//            viewer.Graph = tree;
//            graph_panel.SuspendLayout();
//            graph_panel.Controls.Clear();
//            viewer.Dock = DockStyle.Fill;
//            graph_panel.Controls.Add(viewer);
//            graph_panel.ResumeLayout();
//            graph_panel.Show();
//        }

//        private void DrawNode(BNode<T> node, string prev)
//        {
//            if (node == null)
//                return;

//            if (node == root)
//            {
//                var root = tree.AddNode(node.GetData().ToString());
//            }
//            else
//            {
//                var edge = (PhyloEdge)tree.AddEdge(node.GetData().ToString(), prev);
//                edge.Length = 1.0;
//            }
//            prev = node.GetData().ToString();

//            DrawNode(node.left, prev);
//            DrawNode(node.right, prev);
//        }
//    }
//}




