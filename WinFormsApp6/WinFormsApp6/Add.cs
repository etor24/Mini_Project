using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp6
{
    public partial class Add : Form
    {
        private SqlCommand cmd;
        private SqlConnection cn;
        public Add()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (cn = new SqlConnection(@"Data Source=DESKTOP-JR9UHT4\SQLEXPRESS; Initial Catalog=clothesCatalogue; Integrated Security=True;"))
                {
                    cn.Open();
                    using (cmd = new SqlCommand("INSERT INTO clothes (clothingItem, color, size, available, brand) VALUES (@clothingItem, @color, @size, @available, @brand);", cn))

                    {
                        if (ClothingItem.Text != "" && color.Text != "" && size.Text != "" && Availability.Text != "" && Brand.Text != "")
                        {
                            cmd.Parameters.AddWithValue("@clothingItem", ClothingItem.Text);
                            cmd.Parameters.AddWithValue("@color", color.Text);
                            cmd.Parameters.AddWithValue("@size", size.Text);
                            cmd.Parameters.AddWithValue("@available", Availability.Text);
                            cmd.Parameters.AddWithValue("@brand", Brand.Text);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Clothing item added.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Hide();
                        }
                        else
                        {
                            MessageBox.Show("Please fill all fields.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
