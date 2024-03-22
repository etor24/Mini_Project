using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp6
{
    public partial class Edit : Form
    {
        private SqlCommand cmd;
        private SqlConnection cn;

        int itemID = Menu.Item_id;
        public Edit()
        {
            InitializeComponent();
            try
            {
                using (cn = new SqlConnection(@"Data Source=DESKTOP-JR9UHT4\SQLEXPRESS; Initial Catalog=clothesCatalogue; Integrated Security=True;"))
                {
                    cn.Open();
                    using (cmd = new SqlCommand("Select clothingItem, color, size, available, brand From clothes WHERE clothes_id = @clothes_id;", cn))

                    {
                        cmd.Parameters.AddWithValue("@clothes_id", itemID);
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            SqlDataReader reader = cmd.ExecuteReader();
                            while (reader.Read())
                            {
                                ClothingItem.Text = reader.GetString(0);
                                color.Text = reader.GetString(1);
                                Size.Text = reader.GetString(2);
                                Availability.Text = reader.GetString(3);
                                Brand.Text = reader.GetString(4);
                            }

                        }
                        else
                        {
                            MessageBox.Show("No such clothing item exists", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                using (cn = new SqlConnection(@"Data Source=DESKTOP-JR9UHT4\SQLEXPRESS; Initial Catalog=clothesCatalogue; Integrated Security=True;"))
                {
                    cn.Open();
                    using (cmd = new SqlCommand("UPDATE clothes SET clothingItem = @clothingItem,  color = @color,  size = @size, available=@available, brand=@brand WHERE clothes_id = @clothes_id;", cn))

                    {
                        if (ClothingItem.Text != "" && color.Text != "" && Size.Text != "" && Availability.Text != "" && Brand.Text != "")
                        {
                            cmd.Parameters.AddWithValue("@clothes_id", itemID);
                            cmd.Parameters.AddWithValue("@clothingItem", ClothingItem.Text);
                            cmd.Parameters.AddWithValue("@color", color.Text);
                            cmd.Parameters.AddWithValue("@size", Size.Text);
                            cmd.Parameters.AddWithValue("@available", Availability.Text);
                            cmd.Parameters.AddWithValue("@brand", Brand.Text);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Clothing item edited and saved.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
