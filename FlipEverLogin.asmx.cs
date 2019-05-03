using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Data;
using System.Web.Script.Services;
namespace FlipEver
{
    /// <summary>
    /// Summary description for FlipEverLogin
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class FlipEverLogin : System.Web.Services.WebService
    {

        [WebMethod]
        public int Login(string name, string pass)
        {
          
            try
            {
                int yes = 1;
                string cn = System.Configuration.ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString;
                SqlConnection con = new SqlConnection(cn);

                string query = "SELECT Name,password FROM loginFlipever WHERE password='" + pass + "' ";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return yes;

            }
            catch
            {
                return -1;
            }
        }

        [WebMethod]

        public int Register(string name, string pass)
        {
            string cn = System.Configuration.ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(cn);
            try
            {
                int status = 1;
                string q = string.Empty;
                q = "insert into loginFlipever (Name,password)values('" + name + "','" + pass + "')";
                SqlCommand cmd = new SqlCommand(q, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                return status;
            }
            catch
            {
                return -1;
            }

        }



    }
}