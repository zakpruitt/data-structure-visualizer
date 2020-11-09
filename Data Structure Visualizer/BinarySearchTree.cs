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

        public void SetData(T data)
        {
            this.data = data;
        }

        public override string ToString()
        {
            if (left == null && right == null)
            {
                return $"Node: Data = {data}, Left, Right = null";
            }
            else if (left == null && right != null)
            {
                return $"Node: Data = {data}, Left, Right= null, {right.GetData()}";
            }
            else if (left != null && right == null)
            {
                return $"Node: Data = {data}, Left, Right = {left.GetData()}, null";
            }
            else
            {
                return $"Node: Data = {data}, Left, Right = {left.GetData()}, {right.GetData()}";
            }
        }
    }

    class BinarySearchTree<T> where T : IComparable<T>
    {
        // DATA MEMBERS
        private BNode<T> root;
        private BNode<T> found = null;

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
                found = vertex;
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

        // this method mainly calls Delete()  
        public void DeleteBNode(T key)
        {
            root = Delete(root, key);
        }

        // a recursive function to insert a new key in BST
        private BNode<T> Delete(BNode<T> node, T key)
        {
            /* Base Case: If the tree is empty */
            if (node == null) return node;

            dynamic value = node.GetData();
            /* Otherwise, recur down the tree */
            if (key < value)
                node.left = Delete(node.left, key);
            else if (key > value)
                node.right = Delete(node.right, key);

            // if key is same as root's key, then This is the node  
            // to be deleted  
            else
            {
                // node with only one child or no child  
                if (node.left == null)
                    return node.right;
                else if (node.right == null)
                    return node.left;

                // node with two children: Get the 
                // inorder successor (smallest  
                // in the right subtree)  
                node.SetData(GetMinValue(node.right));

                // Delete the inorder successor  
                node.right = Delete(node.right, node.GetData());
            }
            return node;
        }

        private T GetMinValue(BNode<T> root)
        {
            T minv = root.GetData();
            while (root.left != null)
            {
                minv = root.left.GetData();
                root = root.left;
            }
            return minv;
        }

        public void Draw(Panel graph_panel)
        {
            // create objects
            GViewer viewer = new GViewer();
            Graph graph = new Graph("graph");

            // defaults to inorder
            DrawNodes(graph, root, Root.GetData().ToString());

            if (found != null)
            {
                var node = graph.FindNode(found.GetData().ToString());
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

        private void DrawNodes(Graph graph, BNode<T> node, string prev)
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

            DrawNodes(graph, node.left, prev);
            DrawNodes(graph, node.right, prev);
        }
    }
}


