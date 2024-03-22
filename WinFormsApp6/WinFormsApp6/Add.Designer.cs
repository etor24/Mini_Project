namespace WinFormsApp6
{
    partial class Add
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
            cancel = new Button();
            button1 = new Button();
            Availability = new TextBox();
            Brand = new TextBox();
            size = new TextBox();
            color = new TextBox();
            ClothingItem = new TextBox();
            SuspendLayout();
            // 
            // cancel
            // 
            cancel.Location = new Point(276, 41);
            cancel.Name = "cancel";
            cancel.Size = new Size(100, 23);
            cancel.TabIndex = 18;
            cancel.Text = "Cancel";
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += cancel_Click;
            // 
            // button1
            // 
            button1.Location = new Point(170, 41);
            button1.Name = "button1";
            button1.Size = new Size(100, 23);
            button1.TabIndex = 17;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Availability
            // 
            Availability.Location = new Point(436, 12);
            Availability.Name = "Availability";
            Availability.PlaceholderText = "Availability";
            Availability.Size = new Size(100, 23);
            Availability.TabIndex = 16;
            // 
            // Brand
            // 
            Brand.Location = new Point(330, 12);
            Brand.Name = "Brand";
            Brand.PlaceholderText = "Brand";
            Brand.Size = new Size(100, 23);
            Brand.TabIndex = 15;
            // 
            // size
            // 
            size.Location = new Point(224, 12);
            size.Name = "size";
            size.PlaceholderText = "Size";
            size.Size = new Size(100, 23);
            size.TabIndex = 14;
            // 
            // color
            // 
            color.Location = new Point(118, 12);
            color.Name = "color";
            color.PlaceholderText = "Color";
            color.Size = new Size(100, 23);
            color.TabIndex = 13;
            // 
            // ClothingItem
            // 
            ClothingItem.Location = new Point(12, 12);
            ClothingItem.Name = "ClothingItem";
            ClothingItem.PlaceholderText = "Clothing item";
            ClothingItem.Size = new Size(100, 23);
            ClothingItem.TabIndex = 12;
            // 
            // Add
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(553, 95);
            Controls.Add(cancel);
            Controls.Add(button1);
            Controls.Add(Availability);
            Controls.Add(Brand);
            Controls.Add(size);
            Controls.Add(color);
            Controls.Add(ClothingItem);
            Name = "Add";
            Text = "Add";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cancel;
        private Button button1;
        private TextBox Availability;
        private TextBox Brand;
        private TextBox size;
        private TextBox color;
        private TextBox ClothingItem;
    }
}