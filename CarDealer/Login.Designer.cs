namespace CarDealer
{
    partial class Login
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
            label6 = new Label();
            label5 = new Label();
            checkBox1 = new CheckBox();
            label4 = new Label();
            button1 = new Button();
            label3 = new Label();
            passwordBox = new TextBox();
            label1 = new Label();
            usernameBox = new TextBox();
            button6 = new Button();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.DeepSkyBlue;
            label6.Location = new Point(244, 411);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 22;
            label6.Text = "Register";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(76, 411);
            label5.Name = "label5";
            label5.Size = new Size(175, 20);
            label5.TabIndex = 21;
            label5.Text = "Don't have an account? ";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Nirmala UI", 7.85454559F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(181, 241);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(112, 19);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala UI", 20.2909088F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(151, 26);
            label4.Name = "label4";
            label4.Size = new Size(100, 42);
            label4.TabIndex = 19;
            label4.Text = "Login";
            // 
            // button1
            // 
            button1.ForeColor = Color.DimGray;
            button1.Location = new Point(95, 281);
            button1.Name = "button1";
            button1.Size = new Size(198, 28);
            button1.TabIndex = 4;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(95, 185);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 17;
            label3.Text = "Password";
            // 
            // passwordBox
            // 
            passwordBox.Font = new Font("Nirmala UI", 9.818182F);
            passwordBox.ForeColor = Color.Black;
            passwordBox.Location = new Point(95, 208);
            passwordBox.Name = "passwordBox";
            passwordBox.PasswordChar = '*';
            passwordBox.Size = new Size(198, 27);
            passwordBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(95, 128);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 13;
            label1.Text = "Username";
            // 
            // usernameBox
            // 
            usernameBox.Font = new Font("Nirmala UI", 9.818182F);
            usernameBox.ForeColor = Color.Black;
            usernameBox.Location = new Point(95, 151);
            usernameBox.Name = "usernameBox";
            usernameBox.Size = new Size(198, 27);
            usernameBox.TabIndex = 1;
            // 
            // button6
            // 
            button6.BackColor = Color.Gainsboro;
            button6.Cursor = Cursors.Hand;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = Color.Black;
            button6.Location = new Point(340, 12);
            button6.Name = "button6";
            button6.Size = new Size(30, 30);
            button6.TabIndex = 5;
            button6.Text = "X";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(382, 456);
            Controls.Add(button6);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(checkBox1);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(passwordBox);
            Controls.Add(label1);
            Controls.Add(usernameBox);
            Font = new Font("Nirmala UI", 9.818182F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.DarkGray;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label5;
        private CheckBox checkBox1;
        private Label label4;
        private Button button1;
        private Label label3;
        private TextBox passwordBox;
        private Label label1;
        private TextBox usernameBox;
        private Button button6;
    }
}