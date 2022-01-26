using BlogSite.DBClass;
using BlogSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogSite
{
    public partial class AddPost : System.Web.UI.Page
    {
        Guid userId;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                DDLCategory.DataSource = Enum.GetNames(typeof(Category)).ToList();
                DDLCategory.DataBind();
            }
            if (User.Identity.IsAuthenticated)
            {
                var name = Membership.GetUser(User.Identity.Name);
                userId = (Guid)name.ProviderUserKey;
            }
            else
            {
                Server.Transfer("~/default.aspx");
            }

        }

        protected void btnPost_Click(object sender, EventArgs e)
        {
            var cid = (int)Enum.Parse(typeof(Category), DDLCategory.SelectedValue);
            Opperations Opp = new Opperations();
            BlogModel b = new BlogModel();
            b.UserId = userId;
            b.BlogCategoryId = cid;
            b.BlogContent = txtContent.Text;
            b.BlogDescription = txtBoxDescription.Text;
            b.BlogTitle = txtBoxTitle.Text;
            b.BlogType = txtBoxType.Text;
            if (Opp.CreateBlog(b))
            {
                lblStatus.Text = "Success";
                lblStatus.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblStatus.Text = "Failed";
                lblStatus.ForeColor = System.Drawing.Color.Green;
            }
        }
    }
}