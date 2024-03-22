using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp6
{
    public partial class Catalogue : Form
    {
        public Catalogue()
        {
            InitializeComponent();
        }
        // Event handler for when the form is loaded
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = null;
                clothingItem.SelectedIndex = -1;
                color.SelectedIndex = -1;
                size.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-JR9UHT4\SQLEXPRESS; Initial Catalog=clothesCatalogue; Integrated Security=True;"))
                {
                    sqlCon.Open(); // Open SQL connection

                    // Start with a base SQL query
                    string query = "SELECT * FROM clothes WHERE 1 = 1";

                    // Create a list to store the conditions for filtering
                    List<string> conditions = new List<string>();

                    // Check each ComboBox and add a condition if an item is selected
                    if (clothingItem.SelectedItem != null)
                        conditions.Add("clothingItem = @clothingItem");

                    if (color.SelectedItem != null)
                        conditions.Add("color = @color");

                    if (size.SelectedItem != null)
                        conditions.Add("size = @size");

                    if (brand.SelectedItem != null)
                        conditions.Add("brand = @brand");

                    // combine the conditions into the SQL query
                    if (conditions.Count > 0)
                    {
                        query += " AND " + string.Join(" AND ", conditions);
                    }



                    SqlCommand cmd = new SqlCommand(query, sqlCon);
                    if (clothingItem.SelectedItem != null)
                        cmd.Parameters.AddWithValue("@clothingItem", clothingItem.SelectedItem.ToString());
                    if (color.SelectedItem != null)
                        cmd.Parameters.AddWithValue("@color", color.SelectedItem.ToString());
                    if (size.SelectedItem != null)
                        cmd.Parameters.AddWithValue("@size", size.SelectedItem.ToString());
                    if (brand.SelectedItem != null)
                        cmd.Parameters.AddWithValue("@brand", brand.SelectedItem.ToString());

                    // Use SqlDataAdapter to fetch data and populate DataGridView
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dataGridView1.DataSource = ds.Tables.Count > 0 ? ds.Tables[0] : null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = null;
                clothingItem.SelectedIndex = -1;
                color.SelectedIndex = -1;
                size.SelectedIndex = -1;
                brand.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void order_Click(object sender, EventArgs e)
        {
            try
            {
                using (Order userInputForm = new Order())
                {
                    // Display the form as a dialog
                    userInputForm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                using (Login userInputForm = new Login())
                {
                    // Display the form as a dialog
                    userInputForm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void SearchBar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-JR9UHT4\SQLEXPRESS; Initial Catalog=clothesCatalogue; Integrated Security=True;"))
                {
                    sqlCon.Open();

                    string query = "SELECT * FROM clothes WHERE clothingItem LIKE @Search OR color LIKE @Search OR size LIKE @Search OR brand LIKE @Search";

                    SqlCommand cmd = new SqlCommand(query, sqlCon);
                    cmd.Parameters.AddWithValue("@Search", "%" + SearchBar.Text + "%");


                    // Use SqlDataAdapter to fetch data and populate DataGridView
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dataGridView1.DataSource = ds.Tables.Count > 0 ? ds.Tables[0] : null;
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






