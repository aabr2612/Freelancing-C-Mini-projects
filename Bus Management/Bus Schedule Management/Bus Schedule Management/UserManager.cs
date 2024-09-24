using System;
using System.Data.SqlClient;

namespace Bus_Schedule_Management
{
    internal class UserManager
    {
        private static readonly string connectionString = "Server=(local);Database=BusesDataManagement;Trusted_Connection=True";
        public static string UserSignUp(string username, string password, string role)
        {
            string message;
            if (!CheckUser(username))
            {
                string query = "INSERT INTO Users (Username, Password, Role) VALUES (@Username, @Password, @Role)";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);
                        command.Parameters.AddWithValue("@Role", role);
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            message="Success";
                        }
                        else
                        {
                            message="";
                        }
                    }
                    catch (Exception ex)
                    {
                        message="An error occurred: " + ex.Message;
                    }
                    finally
                    { 
                        connection.Close();
                    }
                }
            }
            else
            {
                message="User exists!";
            }
            return message;
        }
        public static string UserSignIn(string username, string password)
        {
            string message = null;
            string query = "SELECT Role FROM Users WHERE Username=@Username AND Password=@Password;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        message = result.ToString();
                    }
                    else
                    {
                        message = "Invalid credentials";
                    }
                }
                catch (Exception ex)
                {
                    message = "An error occurred: " + ex.Message;
                }
                finally { connection.Close(); }
            }
            return message;
        }
        private static bool CheckUser(string username)
        {
            string query = "SELECT COUNT(*) FROM Users WHERE Username=@Username;";
            bool userExists = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Username", username);
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    if (count > 0)
                    {
                        userExists = true;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    connection.Close();
                }
            }
            return userExists;
        }
    }
}
