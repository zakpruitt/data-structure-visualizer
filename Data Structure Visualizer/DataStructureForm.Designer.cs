namespace Data_Structure_Visualizer
{
    partial class Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("An integer to be placed within the new head node.");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Parameters", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Description");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("InsertHeadNode(int data)", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Node6");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Node7");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Node8");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Linked List", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Stack");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Queue");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Binary Search Tree");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Min Heap");
            this.graph_panel = new System.Windows.Forms.Panel();
            this.control_panel = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.controls_tab = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.clear_button = new System.Windows.Forms.Button();
            this.return_box = new System.Windows.Forms.TextBox();
            this.data_structure_select = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.execute_button = new System.Windows.Forms.Button();
            this.method_select = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.second_parameter_input = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.first_parameter_input = new System.Windows.Forms.TextBox();
            this.method_doc_tab = new System.Windows.Forms.TabPage();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.color_legend_tab = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.control_panel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.controls_tab.SuspendLayout();
            this.method_doc_tab.SuspendLayout();
            this.color_legend_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // graph_panel
            // 
            this.graph_panel.BackColor = System.Drawing.Color.White;
            this.graph_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.graph_panel.Location = new System.Drawing.Point(0, 0);
            this.graph_panel.Margin = new System.Windows.Forms.Padding(2);
            this.graph_panel.Name = "graph_panel";
            this.graph_panel.Size = new System.Drawing.Size(624, 575);
            this.graph_panel.TabIndex = 0;
            // 
            // control_panel
            // 
            this.control_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.control_panel.Controls.Add(this.tabControl1);
            this.control_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.control_panel.Location = new System.Drawing.Point(624, 0);
            this.control_panel.Margin = new System.Windows.Forms.Padding(2);
            this.control_panel.Name = "control_panel";
            this.control_panel.Size = new System.Drawing.Size(221, 575);
            this.control_panel.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.controls_tab);
            this.tabControl1.Controls.Add(this.method_doc_tab);
            this.tabControl1.Controls.Add(this.color_legend_tab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(219, 573);
            this.tabControl1.TabIndex = 0;
            // 
            // controls_tab
            // 
            this.controls_tab.Controls.Add(this.label6);
            this.controls_tab.Controls.Add(this.clear_button);
            this.controls_tab.Controls.Add(this.return_box);
            this.controls_tab.Controls.Add(this.data_structure_select);
            this.controls_tab.Controls.Add(this.label1);
            this.controls_tab.Controls.Add(this.execute_button);
            this.controls_tab.Controls.Add(this.method_select);
            this.controls_tab.Controls.Add(this.label5);
            this.controls_tab.Controls.Add(this.second_parameter_input);
            this.controls_tab.Controls.Add(this.label2);
            this.controls_tab.Controls.Add(this.label4);
            this.controls_tab.Controls.Add(this.label3);
            this.controls_tab.Controls.Add(this.first_parameter_input);
            this.controls_tab.Location = new System.Drawing.Point(4, 22);
            this.controls_tab.Name = "controls_tab";
            this.controls_tab.Padding = new System.Windows.Forms.Padding(3);
            this.controls_tab.Size = new System.Drawing.Size(211, 547);
            this.controls_tab.TabIndex = 0;
            this.controls_tab.Text = "Controls";
            this.controls_tab.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 355);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "Return Value";
            // 
            // clear_button
            // 
            this.clear_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.clear_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_button.ForeColor = System.Drawing.Color.White;
            this.clear_button.Location = new System.Drawing.Point(20, 467);
            this.clear_button.Margin = new System.Windows.Forms.Padding(2);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(171, 36);
            this.clear_button.TabIndex = 14;
            this.clear_button.Text = "Clear Data Structure";
            this.clear_button.UseVisualStyleBackColor = false;
            // 
            // return_box
            // 
            this.return_box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.return_box.Location = new System.Drawing.Point(20, 393);
            this.return_box.Margin = new System.Windows.Forms.Padding(2);
            this.return_box.Name = "return_box";
            this.return_box.ReadOnly = true;
            this.return_box.Size = new System.Drawing.Size(171, 20);
            this.return_box.TabIndex = 12;
            // 
            // data_structure_select
            // 
            this.data_structure_select.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_structure_select.FormattingEnabled = true;
            this.data_structure_select.Items.AddRange(new object[] {
            "Linked List",
            "Stack",
            "Queue",
            "Binary Search Tree",
            "Min Heap"});
            this.data_structure_select.Location = new System.Drawing.Point(20, 49);
            this.data_structure_select.Margin = new System.Windows.Forms.Padding(2);
            this.data_structure_select.Name = "data_structure_select";
            this.data_structure_select.Size = new System.Drawing.Size(171, 24);
            this.data_structure_select.TabIndex = 0;
            this.data_structure_select.SelectedIndexChanged += new System.EventHandler(this.Data_Structure_Changed);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data Structure";
            // 
            // execute_button
            // 
            this.execute_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.execute_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.execute_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.execute_button.ForeColor = System.Drawing.Color.White;
            this.execute_button.Location = new System.Drawing.Point(20, 505);
            this.execute_button.Margin = new System.Windows.Forms.Padding(2);
            this.execute_button.Name = "execute_button";
            this.execute_button.Size = new System.Drawing.Size(171, 36);
            this.execute_button.TabIndex = 10;
            this.execute_button.Text = "Execute Method";
            this.execute_button.UseVisualStyleBackColor = false;
            this.execute_button.Click += new System.EventHandler(this.Execute_Method_Click);
            // 
            // method_select
            // 
            this.method_select.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.method_select.FormattingEnabled = true;
            this.method_select.Items.AddRange(new object[] {
            "InsertTailNode(int data)",
            "RemoveHeadNode()",
            "RemoveTailNode()",
            "InsertAfter(int data, int position)",
            "RemoveAfter(int position)",
            "RemoveTailNode()",
            "Find(int target)",
            "Sort()"});
            this.method_select.Location = new System.Drawing.Point(20, 146);
            this.method_select.Margin = new System.Windows.Forms.Padding(2);
            this.method_select.Name = "method_select";
            this.method_select.Size = new System.Drawing.Size(171, 23);
            this.method_select.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 284);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Second:";
            // 
            // second_parameter_input
            // 
            this.second_parameter_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.second_parameter_input.Location = new System.Drawing.Point(72, 283);
            this.second_parameter_input.Margin = new System.Windows.Forms.Padding(2);
            this.second_parameter_input.Name = "second_parameter_input";
            this.second_parameter_input.Size = new System.Drawing.Size(126, 21);
            this.second_parameter_input.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Method";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 259);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "First:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 217);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Parameters";
            // 
            // first_parameter_input
            // 
            this.first_parameter_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.first_parameter_input.Location = new System.Drawing.Point(72, 258);
            this.first_parameter_input.Margin = new System.Windows.Forms.Padding(2);
            this.first_parameter_input.Name = "first_parameter_input";
            this.first_parameter_input.Size = new System.Drawing.Size(126, 21);
            this.first_parameter_input.TabIndex = 6;
            // 
            // method_doc_tab
            // 
            this.method_doc_tab.Controls.Add(this.treeView1);
            this.method_doc_tab.Location = new System.Drawing.Point(4, 22);
            this.method_doc_tab.Name = "method_doc_tab";
            this.method_doc_tab.Padding = new System.Windows.Forms.Padding(3);
            this.method_doc_tab.Size = new System.Drawing.Size(211, 547);
            this.method_doc_tab.TabIndex = 1;
            this.method_doc_tab.Text = "Method Docs.";
            this.method_doc_tab.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.Location = new System.Drawing.Point(3, 3);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node3";
            treeNode1.Text = "An integer to be placed within the new head node.";
            treeNode2.Name = "Node0";
            treeNode2.Text = "Parameters";
            treeNode3.Name = "Node1";
            treeNode3.Text = "Description";
            treeNode4.Name = "Node5";
            treeNode4.Text = "InsertHeadNode(int data)";
            treeNode5.Name = "Node6";
            treeNode5.Text = "Node6";
            treeNode6.Name = "Node7";
            treeNode6.Text = "Node7";
            treeNode7.Name = "Node8";
            treeNode7.Text = "Node8";
            treeNode8.Name = "ll";
            treeNode8.Text = "Linked List";
            treeNode9.Name = "Node1";
            treeNode9.Text = "Stack";
            treeNode10.Name = "Node2";
            treeNode10.Text = "Queue";
            treeNode11.Name = "Node3";
            treeNode11.Text = "Binary Search Tree";
            treeNode12.Name = "Node4";
            treeNode12.Text = "Min Heap";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12});
            this.treeView1.Size = new System.Drawing.Size(205, 541);
            this.treeView1.TabIndex = 0;
            // 
            // color_legend_tab
            // 
            this.color_legend_tab.Controls.Add(this.pictureBox1);
            this.color_legend_tab.Location = new System.Drawing.Point(4, 22);
            this.color_legend_tab.Name = "color_legend_tab";
            this.color_legend_tab.Padding = new System.Windows.Forms.Padding(3);
            this.color_legend_tab.Size = new System.Drawing.Size(211, 547);
            this.color_legend_tab.TabIndex = 2;
            this.color_legend_tab.Text = "Color Legend";
            this.color_legend_tab.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Data_Structure_Visualizer.Properties.Resources._11;
            this.pictureBox1.Location = new System.Drawing.Point(-4, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 564);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 575);
            this.Controls.Add(this.control_panel);
            this.Controls.Add(this.graph_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form";
            this.Text = "Data Structure Visualizer";
            this.control_panel.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.controls_tab.ResumeLayout(false);
            this.controls_tab.PerformLayout();
            this.method_doc_tab.ResumeLayout(false);
            this.color_legend_tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel graph_panel;
        private System.Windows.Forms.Panel control_panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox data_structure_select;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox method_select;
        private System.Windows.Forms.TextBox second_parameter_input;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox first_parameter_input;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button execute_button;
        private System.Windows.Forms.TextBox return_box;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage controls_tab;
        private System.Windows.Forms.TabPage method_doc_tab;
        private System.Windows.Forms.TabPage color_legend_tab;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TreeView treeView1;
    }
}

