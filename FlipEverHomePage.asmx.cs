using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Web.Configuration;
using System.Web.Script.Services;

namespace FlipEver
{
    /// <summary>
    /// Summary description for FlipEverHomePage1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class FlipEverHomePage1 : System.Web.Services.WebService
    {

        [WebMethod]
       
        public int Insert(string Product_categories, string Product_Name, string Product_Id,string price, string Quantity, string BillAmount)
        {
            string cn = System.Configuration.ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(cn);
            try
            {
                int status = 1;
                string q = string.Empty;
                q = "insert into FlipEvers (Product_categories,Product_Name,Product_Id,price,Quantity,BillAmount)values('" + Product_categories + "','" + Product_Name + "', '" + Product_Id + "','" + price + "','" + Quantity + "','" + BillAmount + "')";
                SqlCommand cmd = new SqlCommand(q, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                
                return (Convert.ToInt32(BillAmount));
            }
            catch
            {
                return -1;
            }
            
        }
        
                
        [WebMethod]
        public int Update(string Product_categories, string Product_Name, string Product_Id, string price, string Quantity, string BillAmount)
        {
            string cn = System.Configuration.ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(cn);
            try
            {
                int status = 1;
                string q = string.Empty;
                q = "update FlipEvers set Product_Name='" + Product_Name + "',Product_categories='" + Product_categories + "',price='" + price + "',BillAmount='" + BillAmount + "',Quantity='" + Quantity + "'   where Product_Id=(" + Product_Id + ")";
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


        [WebMethod]
        public int Delete(string Product_categories, string Product_Name, string Product_Id, string price, string Quantity, string BillAmount)
        {
            string cn = System.Configuration.ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(cn);
            try
            {
                int status = 1;
                string q = string.Empty;
                q = "Delete  from FlipEvers  where Product_Id=(" + Product_Id + ")";
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



      
        //select
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public FlipEver[] getData()
        {
            string cn = System.Configuration.ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(cn);
            FlipEverCollection MyData = new FlipEverCollection();
            try
            {
                string q = string.Empty;
                q = "SELECT* FROM FlipEvers";
                con.Open();
                SqlCommand cmd = new SqlCommand(q, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow DR in dt.Rows)
                {
                    FlipEver obj = new FlipEver();
                    obj.Product_categories = DR["Product_categories"].ToString();
                    obj.Product_Name = DR["Product_Name"].ToString();
                    obj.Product_Id = DR["Product_Id"].ToString();
                    obj.price = DR["price"].ToString();
                    obj.Quantity = DR["Quantity"].ToString();
                    obj.BillAmount = DR["BillAmount"].ToString();
                    MyData.Add(obj);
                }

                return MyData.ToArray();

            }
            catch
            {
                return MyData.ToArray();

            }
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public FlipEver[] getsingleData(int Product_Id)
        {
            string cn = System.Configuration.ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(cn);
            FlipEverCollection MyData = new FlipEverCollection();
            try
            {

                string q = string.Empty;
                q = "SELECT* FROM FlipEvers where Product_Id=(" + Product_Id + ") ";
                con.Open();
                SqlCommand cmd = new SqlCommand(q, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow DR in dt.Rows)
                {
                    FlipEver obj = new FlipEver();
                    obj.Product_categories = DR["Product_categories"].ToString();
                    obj.Product_Name = DR["Product_Name"].ToString();
                    obj.Product_Id = DR["Product_Id"].ToString();
                    obj.price = DR["price"].ToString();
                    obj.Quantity = DR["Quantity"].ToString();
                    obj.BillAmount = DR["BillAmount"].ToString();
                    MyData.Add(obj);
                }

                return MyData.ToArray();

            }
            catch
            {
                return MyData.ToArray();

            }
        }



        //client download image
        

    }


}

