using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.UI.WebControls;

namespace WebFormsProject
{
    public partial class ProductManagement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindProductGrid();
            }
        }

        protected void btnSaveProduct_Click(object sender, EventArgs e)
        {
            SaveProduct(txtProductName.Text, txtProductDescription.Text);

            BindProductGrid();

            ClearInputFields();
        }

        private void SaveProduct(string productName, string productDescription)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["AdoNetKontroleConnectionString"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string insertQuery = "INSERT INTO WebFormsLabos.dbo.Products (Name, Description) VALUES (@ProductName, @ProductDescription)";
                using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@ProductName", productName);
                    cmd.Parameters.AddWithValue("@ProductDescription", productDescription);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void BindProductGrid()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["AdoNetKontroleConnectionString"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string selectQuery = "SELECT * FROM WebFormsLabos.dbo.Products";
                using (SqlCommand cmd = new SqlCommand(selectQuery, connection))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    gvProducts.Columns.Clear();

                    foreach (DataColumn column in dt.Columns)
                    {
                        BoundField field = new BoundField();
                        field.DataField = column.ColumnName;
                        field.HeaderText = column.ColumnName;
                        gvProducts.Columns.Add(field);
                    }

                    gvProducts.DataSource = dt;
                    gvProducts.DataBind();
                }
            }
        }


        private void ClearInputFields()
        {
            txtProductName.Text = string.Empty;
            txtProductDescription.Text = string.Empty;
        }
    }
}
