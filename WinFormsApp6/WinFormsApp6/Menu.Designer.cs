namespace WinFormsApp6
{
    partial class Menu
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
            add = new Button();
            edit = new Button();
            delete = new Button();
            cancel = new Button();
            itemID = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // add
            // 
            add.Location = new Point(12, 12);
            add.Name = "add";
            add.Size = new Size(75, 23);
            add.TabIndex = 0;
            add.Text = "Add Item";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // edit
            // 
            edit.Location = new Point(93, 12);
            edit.Name = "edit";
            edit.Size = new Size(75, 23);
            edit.TabIndex = 1;
            edit.Text = "Edit item";
            edit.UseVisualStyleBackColor = true;
            edit.Click += edit_Click;
            // 
            // delete
            // 
            delete.Location = new Point(174, 12);
            delete.Name = "delete";
            delete.Size = new Size(75, 23);
            delete.TabIndex = 2;
            delete.Text = "Delete Item";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // cancel
            // 
            cancel.Location = new Point(255, 12);
            cancel.Name = "cancel";
            cancel.Size = new Size(75, 23);
            cancel.TabIndex = 3;
            cancel.Text = "Cancel";
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += cancel_Click;
            // 
            // itemID
            // 
            itemID.Location = new Point(93, 41);
            itemID.Name = "itemID";
            itemID.PlaceholderText = "itemID";
            itemID.Size = new Size(156, 23);
            itemID.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 67);
            label1.Name = "label1";
            label1.Size = new Size(292, 15);
            label1.TabIndex = 5;
            label1.Text = "ClothingID is required if item is to be edited or deleted";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(343, 105);
            Controls.Add(label1);
            Controls.Add(itemID);
            Controls.Add(cancel);
            Controls.Add(delete);
            Controls.Add(edit);
            Controls.Add(add);
            Name = "Menu";
            Text = "Edit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button add;
        private Button edit;
        private Button delete;
        private Button cancel;
        private TextBox itemID;
        private Label label1;
    }
}