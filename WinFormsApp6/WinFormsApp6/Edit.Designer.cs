namespace WinFormsApp6
{
    partial class Edit
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
            Availability = new TextBox();
            Brand = new TextBox();
            Size = new TextBox();
            color = new TextBox();
            ClothingItem = new TextBox();
            save = new Button();
            cancel = new Button();
            SuspendLayout();
            // 
            // Availability
            // 
            Availability.Location = new Point(436, 12);
            Availability.Name = "Availability";
            Availability.PlaceholderText = "Availability";
            Availability.Size = new Size(100, 23);
            Availability.TabIndex = 9;
            // 
            // Brand
            // 
            Brand.Location = new Point(330, 12);
            Brand.Name = "Brand";
            Brand.PlaceholderText = "Brand";
            Brand.Size = new Size(100, 23);
            Brand.TabIndex = 8;
            // 
            // Size
            // 
            Size.Location = new Point(224, 12);
            Size.Name = "Size";
            Size.PlaceholderText = "Size";
            Size.Size = new Size(100, 23);
            Size.TabIndex = 7;
            // 
            // color
            // 
            color.Location = new Point(118, 12);
            color.Name = "color";
            color.PlaceholderText = "Color";
            color.Size = new Size(100, 23);
            color.TabIndex = 6;
            // 
            // ClothingItem
            // 
            ClothingItem.Location = new Point(12, 12);
            ClothingItem.Name = "ClothingItem";
            ClothingItem.PlaceholderText = "Clothing item";
            ClothingItem.Size = new Size(100, 23);
            ClothingItem.TabIndex = 5;
            // 
            // save
            // 
            save.Location = new Point(170, 41);
            save.Name = "save";
            save.Size = new Size(100, 23);
            save.TabIndex = 10;
            save.Text = "Save";
            save.UseVisualStyleBackColor = true;
            save.Click += save_Click;
            // 
            // cancel
            // 
            cancel.Location = new Point(276, 41);
            cancel.Name = "cancel";
            cancel.Size = new Size(100, 23);
            cancel.TabIndex = 11;
            cancel.Text = "Cancel";
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += cancel_Click;
            // 
            // Edit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(555, 93);
            Controls.Add(cancel);
            Controls.Add(save);
            Controls.Add(Availability);
            Controls.Add(Brand);
            Controls.Add(Size);
            Controls.Add(color);
            Controls.Add(ClothingItem);
            Name = "Edit";
            Text = "Edit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Availability;
        private TextBox Brand;
        private TextBox Size;
        private TextBox color;
        private TextBox ClothingItem;
        private Button save;
        private Button cancel;
    }
}