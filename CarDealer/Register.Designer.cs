namespace CarDealer
{
    partial class Register
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            usernameBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            emailBox = new TextBox();
            label3 = new Label();
            passwordBox = new TextBox();
            button1 = new Button();
            label4 = new Label();
            checkBox1 = new CheckBox();
            label5 = new Label();
            label6 = new Label();
            button6 = new Button();
            SuspendLayout();
            // 
            // usernameBox
            // 
            usernameBox.Font = new Font("Nirmala UI", 9.818182F);
            usernameBox.Location = new Point(92, 156);
            usernameBox.Name = "usernameBox";
            usernameBox.Size = new Size(198, 27);
            usernameBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 133);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(92, 190);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 4;
            label2.Text = "Email";
            // 
            // emailBox
            // 
            emailBox.Font = new Font("Nirmala UI", 9.818182F);
            emailBox.Location = new Point(92, 213);
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(198, 27);
            emailBox.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(92, 247);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 6;
            label3.Text = "Password";
            // 
            // passwordBox
            // 
            passwordBox.Font = new Font("Nirmala UI", 9.818182F);
            passwordBox.Location = new Point(92, 270);
            passwordBox.Name = "passwordBox";
            passwordBox.PasswordChar = '*';
            passwordBox.Size = new Size(198, 27);
            passwordBox.TabIndex = 3;
            // 
            // button1
            // 
            button1.ForeColor = Color.DimGray;
            button1.Location = new Point(92, 343);
            button1.Name = "button1";
            button1.Size = new Size(198, 28);
            button1.TabIndex = 5;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala UI", 20.2909088F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(125, 31);
            label4.Name = "label4";
            label4.Size = new Size(137, 42);
            label4.TabIndex = 8;
            label4.Text = "Register";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Nirmala UI", 7.85454559F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(178, 303);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(112, 19);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(73, 416);
            label5.Name = "label5";
            label5.Size = new Size(187, 20);
            label5.TabIndex = 10;
            label5.Text = "Already have an account?";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.DeepSkyBlue;
            label6.Location = new Point(256, 416);
            label6.Name = "label6";
            label6.Size = new Size(48, 20);
            label6.TabIndex = 11;
            label6.Text = "Login";
            label6.Click += label6_Click;
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
            button6.TabIndex = 6;
            button6.Text = "X";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // Register
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
            Controls.Add(label2);
            Controls.Add(emailBox);
            Controls.Add(label1);
            Controls.Add(usernameBox);
            Font = new Font("Nirmala UI", 9.818182F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.DarkGray;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usernameBox;
        private Label label1;
        private Label label2;
        private TextBox emailBox;
        private Label label3;
        private TextBox passwordBox;
        private Button button1;
        private Label label4;
        private CheckBox checkBox1;
        private Label label5;
        private Label label6;
        private Button button6;
    }
}
