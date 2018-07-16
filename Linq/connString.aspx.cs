using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace Linq
{
    public partial class connString : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["abc"].ConnectionString;
           using( SqlConnection con = new SqlConnection(CS)){
                SqlCommand cmd = new SqlCommand("Select * from Students", con);
                con.Open();
                GridView1.DataSource = cmd.ExecuteReader();
                GridView1.DataBind();
                


            }

        }
    }
}