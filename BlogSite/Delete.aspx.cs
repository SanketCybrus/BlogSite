using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogSite
{
    public partial class Delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString.Count==0 && !User.Identity.IsAuthenticated)
                Response.Redirect("default.aspx");
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            var blogId = Request.QueryString["id"];
            var conStr = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "delete from BlogAttribute where BlogId=@blogID";
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("blogID", blogId);
                if(cmd.ExecuteNonQuery()>0)
                {
                    txtMsg.Text = "Deletd Sucessfully";
                }
                else
                {
                    txtMsg.Text = "Error occured";
                }
                System.Threading.Thread.Sleep(5000);
                Response.Redirect("default.aspx");
            }
        }
    }
}