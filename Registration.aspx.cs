using System;
using System.Data.SqlClient;
using System.Configuration;

namespace WebFormsProject
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtRepeatPassword.Text)
            {
                lblMessage.Text = "Lozinke se ne podudaraju!";
                lblMessage.ForeColor = System.Drawing.Color.Red;
                return;
            }

            string connectionString = ConfigurationManager.ConnectionStrings["AdoNetKontroleConnectionString"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string insertQuery = "INSERT INTO WebFormsLabos.dbo.Users (UserName, Password, FullName) VALUES (@UserName, @Password, @FullName)";
                using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@UserName", txtUserName.Text);
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@FullName", txtFullName.Text);

                    try
                    {
                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            lblMessage.Text = "Registracija uspješna!";
                            lblMessage.ForeColor = System.Drawing.Color.Green;
                            Response.Redirect("Shop.aspx");
                        }
                        else
                        {
                            lblMessage.Text = "Greška prilikom registracije!";
                            lblMessage.ForeColor = System.Drawing.Color.Red;
                        }
                    }
                    catch (SqlException ex)
                    {
                        if (ex.Number == 2627) 
                        {
                            lblMessage.Text = "Korisničko ime već postoji!";
                            lblMessage.ForeColor = System.Drawing.Color.Red;
                        }
                        else
                        {
                            lblMessage.Text = "Greška prilikom registracije!";
                            lblMessage.ForeColor = System.Drawing.Color.Red;
                        }
                    }
                }
            }
        }
    }
}
