namespace WinFormsApp6
{
    partial class Catalogue
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            dataGridView1 = new DataGridView();
            clothingItem = new ComboBox();
            color = new ComboBox();
            size = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            order = new Button();
            brand = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            SearchBar = new TextBox();
            button4 = new Button();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.DarkSlateGray;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.DarkSeaGreen;
            dataGridView1.Location = new Point(156, 51);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(671, 242);
            dataGridView1.TabIndex = 2;
            // 
            // clothingItem
            // 
            clothingItem.FormattingEnabled = true;
            clothingItem.Items.AddRange(new object[] { "dress", "jacket", "pants", "shirt", "skirt" });
            clothingItem.Location = new Point(12, 69);
            clothingItem.Name = "clothingItem";
            clothingItem.Size = new Size(138, 23);
            clothingItem.TabIndex = 3;
            // 
            // color
            // 
            color.FormattingEnabled = true;
            color.Items.AddRange(new object[] { "red", "blue", "brown", "black" });
            color.Location = new Point(12, 113);
            color.Name = "color";
            color.Size = new Size(138, 23);
            color.TabIndex = 4;
            // 
            // size
            // 
            size.FormattingEnabled = true;
            size.Items.AddRange(new object[] { "S", "M", "L" });
            size.Location = new Point(12, 157);
            size.Name = "size";
            size.Size = new Size(138, 23);
            size.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(12, 234);
            button1.Name = "button1";
            button1.Size = new Size(138, 23);
            button1.TabIndex = 6;
            button1.Text = "Filter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 263);
            button2.Name = "button2";
            button2.Size = new Size(138, 23);
            button2.TabIndex = 10;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 51);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 11;
            label1.Text = "CLOTHING TYPE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 95);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 12;
            label2.Text = "COLOR";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 139);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 13;
            label3.Text = "SIZE";
            // 
            // order
            // 
            order.Location = new Point(545, 22);
            order.Name = "order";
            order.Size = new Size(138, 23);
            order.TabIndex = 14;
            order.Text = "Order";
            order.UseVisualStyleBackColor = true;
            order.Click += order_Click;
            // 
            // brand
            // 
            brand.FormattingEnabled = true;
            brand.Items.AddRange(new object[] { "nike", "adidas", "chanel" });
            brand.Location = new Point(12, 201);
            brand.Name = "brand";
            brand.Size = new Size(138, 23);
            brand.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 183);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 16;
            label4.Text = "BRAND";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(12, 18);
            label5.Name = "label5";
            label5.Size = new Size(81, 25);
            label5.TabIndex = 17;
            label5.Text = "FILTERS";
            // 
            // SearchBar
            // 
            SearchBar.Location = new Point(156, 22);
            SearchBar.Name = "SearchBar";
            SearchBar.PlaceholderText = "Search . . .";
            SearchBar.Size = new Size(383, 23);
            SearchBar.TabIndex = 18;
            SearchBar.TextChanged += SearchBar_TextChanged;
            // 
            // button4
            // 
            button4.Location = new Point(689, 22);
            button4.Name = "button4";
            button4.Size = new Size(138, 23);
            button4.TabIndex = 20;
            button4.Text = "Edit Database";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(748, 9);
            label6.Name = "label6";
            label6.Size = new Size(79, 13);
            label6.TabIndex = 21;
            label6.Text = "requires login";
            // 
            // Catalogue
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(841, 305);
            Controls.Add(label6);
            Controls.Add(button4);
            Controls.Add(SearchBar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(brand);
            Controls.Add(order);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(size);
            Controls.Add(color);
            Controls.Add(clothingItem);
            Controls.Add(dataGridView1);
            Name = "Catalogue";
            Text = "Catalogue";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private DataGridView dataGridView1;
        private ComboBox clothingItem;
        private ComboBox color;
        private ComboBox size;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button order;
        private ComboBox brand;
        private Label label4;
        private Label label5;
        private TextBox SearchBar;
        private Button button4;
        private Label label6;
    }
}