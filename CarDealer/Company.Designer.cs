﻿namespace CarDealer
{
    partial class Company
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
            button7 = new Button();
            button6 = new Button();
            usernameLabel = new Label();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            button5 = new Button();
            companyDataGridView = new DataGridView();
            nameBox = new TextBox();
            label1 = new Label();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            idBox = new TextBox();
            carPanel = new Panel();
            searchBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)companyDataGridView).BeginInit();
            carPanel.SuspendLayout();
            SuspendLayout();
            // 
            // button7
            // 
            button7.BackColor = Color.Gainsboro;
            button7.Cursor = Cursors.Hand;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Location = new Point(805, 10);
            button7.Name = "button7";
            button7.Size = new Size(83, 33);
            button7.TabIndex = 10;
            button7.Text = "Back";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Gainsboro;
            button6.Cursor = Cursors.Hand;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Location = new Point(12, 10);
            button6.Name = "button6";
            button6.Size = new Size(83, 33);
            button6.TabIndex = 11;
            button6.Text = "Logout";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Nirmala UI", 11.7818184F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usernameLabel.Location = new Point(101, 12);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(109, 25);
            usernameLabel.TabIndex = 20;
            usernameLabel.Text = "{username}";
            // 
            // button4
            // 
            button4.BackColor = Color.Gainsboro;
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(515, 434);
            button4.Name = "button4";
            button4.Size = new Size(132, 31);
            button4.TabIndex = 8;
            button4.Text = "Category";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Gainsboro;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(239, 434);
            button3.Name = "button3";
            button3.Size = new Size(132, 31);
            button3.TabIndex = 0;
            button3.Text = "Company";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Gainsboro;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(377, 434);
            button2.Name = "button2";
            button2.Size = new Size(132, 31);
            button2.TabIndex = 7;
            button2.Text = "Type";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Gainsboro;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(101, 434);
            button1.Name = "button1";
            button1.Size = new Size(132, 31);
            button1.TabIndex = 6;
            button1.Text = "Cars";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Gainsboro;
            button5.Cursor = Cursors.Hand;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(653, 434);
            button5.Name = "button5";
            button5.Size = new Size(132, 31);
            button5.TabIndex = 9;
            button5.Text = "Fuel Type";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // companyDataGridView
            // 
            companyDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            companyDataGridView.Location = new Point(3, 3);
            companyDataGridView.Name = "companyDataGridView";
            companyDataGridView.ReadOnly = true;
            companyDataGridView.RowHeadersWidth = 47;
            companyDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            companyDataGridView.Size = new Size(868, 229);
            companyDataGridView.TabIndex = 8;
            companyDataGridView.CellContentClick += companyDataGridView_CellContentClick;
            // 
            // nameBox
            // 
            nameBox.Font = new Font("Nirmala UI", 9.818182F);
            nameBox.Location = new Point(226, 290);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(403, 27);
            nameBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(161, 294);
            label1.Name = "label1";
            label1.Size = new Size(49, 19);
            label1.TabIndex = 11;
            label1.Text = "Name";
            // 
            // button8
            // 
            button8.BackColor = Color.PaleGreen;
            button8.Cursor = Cursors.Hand;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Location = new Point(227, 333);
            button8.Name = "button8";
            button8.Size = new Size(96, 31);
            button8.TabIndex = 2;
            button8.Text = "Insert";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.Khaki;
            button9.Cursor = Cursors.Hand;
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Location = new Point(329, 333);
            button9.Name = "button9";
            button9.Size = new Size(96, 31);
            button9.TabIndex = 3;
            button9.Text = "Update";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.LightCoral;
            button10.Cursor = Cursors.Hand;
            button10.FlatAppearance.BorderSize = 0;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Location = new Point(431, 333);
            button10.Name = "button10";
            button10.Size = new Size(96, 31);
            button10.TabIndex = 4;
            button10.Text = "Delete";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.BackColor = Color.LightSkyBlue;
            button11.Cursor = Cursors.Hand;
            button11.FlatAppearance.BorderSize = 0;
            button11.FlatStyle = FlatStyle.Flat;
            button11.Location = new Point(533, 333);
            button11.Name = "button11";
            button11.Size = new Size(96, 31);
            button11.TabIndex = 5;
            button11.Text = "Clear";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // idBox
            // 
            idBox.BackColor = Color.Silver;
            idBox.Font = new Font("Nirmala UI", 9.818182F);
            idBox.Location = new Point(226, 257);
            idBox.Name = "idBox";
            idBox.ReadOnly = true;
            idBox.Size = new Size(40, 27);
            idBox.TabIndex = 22;
            // 
            // carPanel
            // 
            carPanel.BorderStyle = BorderStyle.FixedSingle;
            carPanel.Controls.Add(searchBox);
            carPanel.Controls.Add(idBox);
            carPanel.Controls.Add(button11);
            carPanel.Controls.Add(button10);
            carPanel.Controls.Add(button9);
            carPanel.Controls.Add(button8);
            carPanel.Controls.Add(label1);
            carPanel.Controls.Add(nameBox);
            carPanel.Controls.Add(companyDataGridView);
            carPanel.Location = new Point(12, 59);
            carPanel.Name = "carPanel";
            carPanel.Size = new Size(876, 369);
            carPanel.TabIndex = 22;
            // 
            // searchBox
            // 
            searchBox.Font = new Font("Nirmala UI", 9.818182F);
            searchBox.ForeColor = Color.Black;
            searchBox.Location = new Point(732, 238);
            searchBox.Name = "searchBox";
            searchBox.PlaceholderText = "Search";
            searchBox.Size = new Size(139, 27);
            searchBox.TabIndex = 24;
            searchBox.TextChanged += searchBox_TextChanged;
            // 
            // Company
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(900, 474);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(usernameLabel);
            Controls.Add(carPanel);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button5);
            Font = new Font("Nirmala UI", 9.163636F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Company";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Company";
            Load += Company_Load;
            ((System.ComponentModel.ISupportInitialize)companyDataGridView).EndInit();
            carPanel.ResumeLayout(false);
            carPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button7;
        private Button button6;
        private Label usernameLabel;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button5;
        private DataGridView companyDataGridView;
        private TextBox nameBox;
        private Label label1;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private TextBox idBox;
        private Panel carPanel;
        private TextBox searchBox;
    }
}