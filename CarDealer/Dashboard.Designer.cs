namespace CarDealer
{
    partial class Dashboard
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
            button1 = new Button();
            usernameLabel = new Label();
            button6 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Gainsboro;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(101, 431);
            button1.Name = "button1";
            button1.Size = new Size(132, 31);
            button1.TabIndex = 1;
            button1.Text = "Cars";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Nirmala UI", 11.7818184F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usernameLabel.Location = new Point(101, 9);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(109, 25);
            usernameLabel.TabIndex = 4;
            usernameLabel.Text = "{username}";
            // 
            // button6
            // 
            button6.BackColor = Color.Gainsboro;
            button6.Cursor = Cursors.Hand;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Location = new Point(12, 7);
            button6.Name = "button6";
            button6.Size = new Size(83, 33);
            button6.TabIndex = 6;
            button6.Text = "Logout";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Gainsboro;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(377, 431);
            button2.Name = "button2";
            button2.Size = new Size(132, 31);
            button2.TabIndex = 3;
            button2.Text = "Type";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Gainsboro;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(239, 431);
            button3.Name = "button3";
            button3.Size = new Size(132, 31);
            button3.TabIndex = 2;
            button3.Text = "Company";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Gainsboro;
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(515, 431);
            button4.Name = "button4";
            button4.Size = new Size(132, 31);
            button4.TabIndex = 4;
            button4.Text = "Category";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Gainsboro;
            button5.Cursor = Cursors.Hand;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(653, 431);
            button5.Name = "button5";
            button5.Size = new Size(132, 31);
            button5.TabIndex = 5;
            button5.Text = "Fuel Type";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 20.2909088F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(176, 203);
            label1.Name = "label1";
            label1.Size = new Size(550, 42);
            label1.TabIndex = 10;
            label1.Text = "Welcome to Antipole Car Dealership";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(900, 474);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button6);
            Controls.Add(usernameLabel);
            Controls.Add(button1);
            Font = new Font("Nirmala UI", 9.818182F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label usernameLabel;
        private Button button6;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label1;
    }
}