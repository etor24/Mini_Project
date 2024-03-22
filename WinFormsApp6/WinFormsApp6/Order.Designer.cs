namespace WinFormsApp6
{
    partial class Order
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
            fName = new TextBox();
            lName = new TextBox();
            email = new TextBox();
            date = new DateTimePicker();
            label1 = new Label();
            buy = new Button();
            address = new TextBox();
            clothesID = new TextBox();
            SuspendLayout();
            // 
            // fName
            // 
            fName.Location = new Point(12, 12);
            fName.Name = "fName";
            fName.PlaceholderText = "First Name";
            fName.Size = new Size(100, 23);
            fName.TabIndex = 0;
            // 
            // lName
            // 
            lName.Location = new Point(118, 12);
            lName.Name = "lName";
            lName.PlaceholderText = "Last Name";
            lName.Size = new Size(100, 23);
            lName.TabIndex = 1;
            // 
            // email
            // 
            email.Location = new Point(12, 41);
            email.Name = "email";
            email.PlaceholderText = "email";
            email.Size = new Size(206, 23);
            email.TabIndex = 2;
            // 
            // date
            // 
            date.Location = new Point(12, 116);
            date.Name = "date";
            date.Size = new Size(205, 23);
            date.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 98);
            label1.Name = "label1";
            label1.Size = new Size(121, 15);
            label1.TabIndex = 4;
            label1.Text = "Preffered Arrival Time";
            // 
            // buy
            // 
            buy.Location = new Point(12, 174);
            buy.Name = "buy";
            buy.Size = new Size(206, 23);
            buy.TabIndex = 8;
            buy.Text = "Order";
            buy.UseVisualStyleBackColor = true;
            buy.Click += buy_Click;
            // 
            // address
            // 
            address.Location = new Point(12, 70);
            address.Name = "address";
            address.PlaceholderText = "address";
            address.Size = new Size(205, 23);
            address.TabIndex = 4;
            // 
            // clothesID
            // 
            clothesID.Location = new Point(12, 145);
            clothesID.Name = "clothesID";
            clothesID.PlaceholderText = "Clothing ID";
            clothesID.Size = new Size(206, 23);
            clothesID.TabIndex = 9;
            // 
            // Order
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(229, 205);
            Controls.Add(clothesID);
            Controls.Add(address);
            Controls.Add(buy);
            Controls.Add(label1);
            Controls.Add(date);
            Controls.Add(email);
            Controls.Add(lName);
            Controls.Add(fName);
            Name = "Order";
            Text = "Order";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox fName;
        private TextBox lName;
        private TextBox email;
        private DateTimePicker date;
        private Label label1;
        private Button buy;
        private ComboBox clothes_id;
        private TextBox address;
        private TextBox textBox1;
        private TextBox clothesID;
    }
}