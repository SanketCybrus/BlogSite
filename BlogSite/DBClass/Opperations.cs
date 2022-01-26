using BlogSite.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BlogSite.DBClass
{
    public class Opperations
    {
        private SqlConnection _con;
        SqlTransaction transaction;
        string conStr;
        public Opperations()
        {
             conStr = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;        
        }
        public bool CreateBlog(BlogModel data)
        {
            try
            {
                using (_con = new SqlConnection(conStr))
                {
                    _con.Open();
                    transaction = _con.BeginTransaction();
                    string query = "insert into BlogAttribute (BlogUserId,BlogTitle,BlogContent,BlogDescription,BlogType,BlogCategoryId) values (@UserId,@Title,@Content,@Description,@Type,@Category)";
                    SqlCommand command = new SqlCommand();
                    command.CommandText = query;
                    command.Connection = _con;
                    command.Transaction=transaction;
                    command.Parameters.AddWithValue("UserId", data.UserId);
                    command.Parameters.AddWithValue("Title", data.BlogTitle);
                    command.Parameters.AddWithValue("Content", data.BlogContent);
                    command.Parameters.AddWithValue("Description", data.BlogDescription);
                    command.Parameters.AddWithValue("Type", data.BlogType);
                    command.Parameters.AddWithValue("Category", data.BlogCategoryId);
                    if (command.ExecuteNonQuery() > 0)
                    {
                        transaction.Commit();
                        return true;
                    }
                }
            }
            catch (SqlException e)
            {
                transaction.Rollback();
            }

            return false;
        }
    }
}