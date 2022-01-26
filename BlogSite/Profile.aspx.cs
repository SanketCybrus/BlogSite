using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.Security;


namespace BlogSite
{
    public partial class Profile : System.Web.UI.Page
    {
        Guid userId;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (User.Identity.IsAuthenticated)
            {
                var name = Membership.GetUser(User.Identity.Name);
                userId = (Guid)name.ProviderUserKey;
                GenerateData();
            }
            else
            {
                Server.Transfer("~/default.aspx");
            }
        }
        private void GenerateData()
        {
            var conStr = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select * from BlogAttribute where BlogUserId like @userID";
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("userID", userId);
                GridView1.DataSource = cmd.ExecuteReader();                
                GridView1.DataBind();      
                foreach (System.Web.UI.WebControls.GridViewRow row in GridView1.Rows)
                {
                    System.Web.UI.WebControls.TableCell cell = new System.Web.UI.WebControls.TableCell();
                    System.Web.UI.WebControls.LinkButton btn = new System.Web.UI.WebControls.LinkButton();     
                    btn.Text = "Delete";
                    btn.PostBackUrl = "~/Delete.aspx?id=" + row.Cells[0].Text;
                    cell.Controls.Add(btn);
                    row.Cells.Add(cell);
                }
            }
        }

        protected void GridView1_DataBound(object sender, EventArgs e)
        {
           // this.GridView1.Columns[0].Visible = false;
        }

        protected void GridView1_RowDataBound(object sender, System.Web.UI.WebControls.GridViewRowEventArgs e)
        {
            e.Row.Cells[0].Visible = false;
            e.Row.Cells[1].Visible = false;
            e.Row.Cells[3].Visible = false;
            e.Row.Cells[6].Visible = false;
        }
    }
}