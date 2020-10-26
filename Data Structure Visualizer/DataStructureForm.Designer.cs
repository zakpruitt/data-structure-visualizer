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
            this.graph_panel = new System.Windows.Forms.Panel();
            this.control_panel = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.controls_tab = new System.Windows.Forms.TabPage();
            this.return_box = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
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
            this.color_legend_tab = new System.Windows.Forms.TabPage();
            this.control_panel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.controls_tab.SuspendLayout();
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
            this.controls_tab.Controls.Add(this.return_box);
            this.controls_tab.Controls.Add(this.label6);
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
            // return_box
            // 
            this.return_box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.return_box.Location = new System.Drawing.Point(75, 514);
            this.return_box.Margin = new System.Windows.Forms.Padding(2);
            this.return_box.Name = "return_box";
            this.return_box.ReadOnly = true;
            this.return_box.Size = new System.Drawing.Size(116, 20);
            this.return_box.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 517);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "return value:";
            // 
            // data_structure_select
            // 
            this.data_structure_select.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_structure_select.FormattingEnabled = true;
            this.data_structure_select.Items.AddRange(new object[] {
            "Linked List",
            "Stack",
            "Queue",
            "Binary Search Tree"});
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
            this.execute_button.Location = new System.Drawing.Point(65, 398);
            this.execute_button.Margin = new System.Windows.Forms.Padding(2);
            this.execute_button.Name = "execute_button";
            this.execute_button.Size = new System.Drawing.Size(75, 27);
            this.execute_button.TabIndex = 10;
            this.execute_button.Text = "Execute";
            this.execute_button.UseVisualStyleBackColor = true;
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
            this.label5.Location = new System.Drawing.Point(13, 266);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Second:";
            // 
            // second_parameter_input
            // 
            this.second_parameter_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.second_parameter_input.Location = new System.Drawing.Point(79, 265);
            this.second_parameter_input.Margin = new System.Windows.Forms.Padding(2);
            this.second_parameter_input.Name = "second_parameter_input";
            this.second_parameter_input.Size = new System.Drawing.Size(112, 21);
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
            this.label4.Location = new System.Drawing.Point(17, 238);
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
            this.label3.Location = new System.Drawing.Point(52, 197);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Parameters";
            // 
            // first_parameter_input
            // 
            this.first_parameter_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.first_parameter_input.Location = new System.Drawing.Point(79, 237);
            this.first_parameter_input.Margin = new System.Windows.Forms.Padding(2);
            this.first_parameter_input.Name = "first_parameter_input";
            this.first_parameter_input.Size = new System.Drawing.Size(112, 21);
            this.first_parameter_input.TabIndex = 6;
            // 
            // method_doc_tab
            // 
            this.method_doc_tab.Location = new System.Drawing.Point(4, 22);
            this.method_doc_tab.Name = "method_doc_tab";
            this.method_doc_tab.Padding = new System.Windows.Forms.Padding(3);
            this.method_doc_tab.Size = new System.Drawing.Size(211, 547);
            this.method_doc_tab.TabIndex = 1;
            this.method_doc_tab.Text = "Method Docs.";
            this.method_doc_tab.UseVisualStyleBackColor = true;
            // 
            // color_legend_tab
            // 
            this.color_legend_tab.Location = new System.Drawing.Point(4, 22);
            this.color_legend_tab.Name = "color_legend_tab";
            this.color_legend_tab.Padding = new System.Windows.Forms.Padding(3);
            this.color_legend_tab.Size = new System.Drawing.Size(211, 547);
            this.color_legend_tab.TabIndex = 2;
            this.color_legend_tab.Text = "Color Legend";
            this.color_legend_tab.UseVisualStyleBackColor = true;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel graph_panel;
        private System.Windows.Forms.Panel control_panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox data_structure_select;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox method_select;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox second_parameter_input;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox first_parameter_input;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button execute_button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox return_box;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage controls_tab;
        private System.Windows.Forms.TabPage method_doc_tab;
        private System.Windows.Forms.TabPage color_legend_tab;
    }
}

