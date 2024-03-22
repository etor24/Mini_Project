namespace WinFormsApp6
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
            username = new TextBox();
            password = new TextBox();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // username
            // 
            username.Location = new Point(12, 71);
            username.Name = "username";
            username.PlaceholderText = "username";
            username.Size = new Size(177, 23);
            username.TabIndex = 0;
            // 
            // password
            // 
            password.Location = new Point(12, 100);
            password.Name = "password";
            password.PasswordChar = '*';
            password.PlaceholderText = "password";
            password.Size = new Size(177, 23);
            password.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(54, 9);
            label3.Name = "label3";
            label3.Size = new Size(91, 37);
            label3.TabIndex = 4;
            label3.Text = "Log in";
            // 
            // button1
            // 
            button1.Location = new Point(54, 140);
            button1.Name = "button1";
            button1.Size = new Size(91, 23);
            button1.TabIndex = 5;
            button1.Text = "log in";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(201, 175);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(password);
            Controls.Add(username);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox username;
        private TextBox password;
        private Label label3;
        private Button button1;
    }
}