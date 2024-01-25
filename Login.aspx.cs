using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.UI;

namespace WebFormsProject
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string enteredUsername = txtUsername.Text;
            string enteredPassword = txtPassword.Text;

            string connectionString = ConfigurationManager.ConnectionStrings["AdoNetKontroleConnectionString"].ConnectionString;
            string selectQuery = "SELECT Password FROM Users WHERE UserName = @UserName";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(selectQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@UserName", enteredUsername);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        string storedPassword = result.ToString();

                        if (enteredPassword == storedPassword)
                        {
                            Response.Redirect("~/Shop.aspx");
                        }
                        else
                        {
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "InvalidLogin", "alert('Invalid username or password.');", true);
                        }
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "UserNotFound", "alert('User not found.');", true);
                    }
                }
            }
        }
    }
}
