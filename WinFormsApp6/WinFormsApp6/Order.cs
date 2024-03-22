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
    public partial class Order : Form
    {
        private SqlCommand cmd;
        private SqlConnection cn;
        public Order()
        {
            InitializeComponent();
        }

        private void buy_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-JR9UHT4\SQLEXPRESS; Initial Catalog=clothesCatalogue; Integrated Security=True;"))
                {
                    sqlCon.Open(); // Open SQL connection

                    if (fName.Text != "" && lName.Text != "" && email.Text != "" && address.Text != "" && clothesID.Text != "")
                    {
                        using (cn = new SqlConnection(@"Data Source=DESKTOP-JR9UHT4\SQLEXPRESS; Initial Catalog=clothesCatalogue; Integrated Security=True;"))
                        {
                            cn.Open();
                            using (cmd = new SqlCommand("Select * From clothes WHERE clothes_id = @clothesID", cn))
                            {
                                cmd.Parameters.AddWithValue("@clothesID", clothesID.Text);
                                object result = cmd.ExecuteScalar();
                                if (result != null)
                                {
                                    string availabilityQuery = "SELECT available FROM clothes WHERE clothes_id = @clothes_id";
                                    SqlCommand availabilityCmd = new SqlCommand(availabilityQuery, sqlCon);
                                    availabilityCmd.Parameters.AddWithValue("@clothes_id", Convert.ToInt32(clothesID.Text));
                                    string availabilityResult = availabilityCmd.ExecuteScalar().ToString().Trim();

                                    if (availabilityResult.Equals("yes", StringComparison.OrdinalIgnoreCase))
                                    {
                                        string insertQuery = "INSERT INTO user_info VALUES (@firstName, @lastName, @email,@address, @date, @clothes_id)";
                                        SqlCommand insertCmd = new SqlCommand(insertQuery, sqlCon);

                                        insertCmd.Parameters.AddWithValue("@firstName", fName.Text);
                                        insertCmd.Parameters.AddWithValue("@lastName", lName.Text);
                                        insertCmd.Parameters.AddWithValue("@email", email.Text);
                                        insertCmd.Parameters.AddWithValue("@address", address.Text);
                                        insertCmd.Parameters.AddWithValue("@date", date.Value);
                                        insertCmd.Parameters.AddWithValue("@clothes_id", Convert.ToInt32(clothesID.Text));

                                        insertCmd.ExecuteNonQuery();

                                        string updateAvailabilityQuery = "UPDATE clothes SET available = 'no' WHERE clothes_id = @clothes_id";
                                        SqlCommand updateAvailabilityCmd = new SqlCommand(updateAvailabilityQuery, sqlCon);
                                        updateAvailabilityCmd.Parameters.AddWithValue("@clothes_id", clothesID.Text);
                                        updateAvailabilityCmd.ExecuteNonQuery();

                                        MessageBox.Show("Purchase Successful!");
                                        Hide();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Sorry, the clothing item is not available for purchase.");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("No such item exists", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }

                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please fill all fields.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
