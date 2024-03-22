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
    public partial class Menu : Form
    {
        private SqlCommand cmd;
        private SqlConnection cn;
        public static int Item_id { get; set; }


        public Menu()
        {
            InitializeComponent();

        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                using (cn = new SqlConnection(@"Data Source=DESKTOP-JR9UHT4\SQLEXPRESS; Initial Catalog=clothesCatalogue; Integrated Security=True;"))
                {
                    cn.Open();
                    using (cmd = new SqlCommand("Select * From clothes WHERE clothes_id = @ItemID", cn))
                    {
                        cmd.Parameters.AddWithValue("@ItemID", itemID.Text);
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            using (cmd = new SqlCommand("DELETE FROM clothes WHERE clothes_id = @ItemID", cn))
                            {
                                cmd.Parameters.AddWithValue("@ItemID", itemID.Text);

                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Clothing item deleted.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("No such item exists", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void edit_Click(object sender, EventArgs e)
        {
            try
            {
                using (cn = new SqlConnection(@"Data Source=DESKTOP-JR9UHT4\SQLEXPRESS; Initial Catalog=clothesCatalogue; Integrated Security=True;"))
                {
                    cn.Open();
                    using (cmd = new SqlCommand("Select * From clothes WHERE clothes_id = @ItemID", cn))

                    {
                        cmd.Parameters.AddWithValue("@ItemID", itemID.Text);
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            Item_id = Convert.ToInt32(itemID.Text);
                            using (Edit userInputForm = new Edit())
                            {
                                userInputForm.ShowDialog();
                            }
                        }
                        else
                        {
                            MessageBox.Show("No such item exists", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void add_Click(object sender, EventArgs e)
        {
            using (Add userInputForm = new Add())
            {
                userInputForm.ShowDialog();
            }
        }
    }
}
