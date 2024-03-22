using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp6
{
    internal class authentication
    {
        public class User
        {
            public string Username { get; set; }
        }

        public class DatabaseManager
        {
            // Method to authenticate use
            public static User AuthenticateUser(string username, string password)
            {
                try
                {
                    User user = RetrieveUserInformation(username, password);
                    return user;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }

            }

            private static User RetrieveUserInformation(string username, string password)
            {
                try
                {
                    using (SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-JR9UHT4\SQLEXPRESS; Initial Catalog=clothesCatalogue; Integrated Security=True;"))
                    {
                        sqlCon.Open(); // Open SQL connection

                        string loginQuery = "SELECT COUNT(1) FROM staff_info WHERE username=@username AND password=@password";
                        using (SqlCommand loginCmd = new SqlCommand(loginQuery, sqlCon))
                        {
                            loginCmd.CommandType = CommandType.Text;
                            loginCmd.Parameters.AddWithValue("@username", username);
                            loginCmd.Parameters.AddWithValue("@password", password);

                            int count = Convert.ToInt32(loginCmd.ExecuteScalar());

                            if (count == 1)
                            {

                                return new User { Username = username, };
                            }

                            return null; // Return null if no user is found with the specified username and password

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }
    }
}
