using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleWebApp
{
    public partial class BookStore : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindBooks();
            }
        }
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            BindBooks();
        }

        private void BindBooks()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string searchCriteria = txtSearchCriteria.Text.Trim();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT Title, Author, Genre, PublicationYear FROM Books WHERE Title LIKE '%' + @SearchCriteria + '%' OR Author LIKE '%' + @SearchCriteria + '%'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@SearchCriteria", searchCriteria);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                rptBooks.DataSource = dt;
                rptBooks.DataBind();
            }
        }

    }
}