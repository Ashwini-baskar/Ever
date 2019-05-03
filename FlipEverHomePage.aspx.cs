using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.IO;

namespace FlipEver
{
    public partial class FlipEverHomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //sever side code file upload
        protected void Bt_upload_Click(object sender, EventArgs e)
        {
            string folderPath = Server.MapPath("~/uploads/");

            //Check whether Directory (Folder) exists.
            if (!Directory.Exists(folderPath))
            {
                //If Directory (Folder) does not exists Create it.
                Directory.CreateDirectory(folderPath);
            }

            //Save the File to the Directory (Folder).
            FileUpload_file.SaveAs(folderPath + FileUpload_file.FileName);

            //Display the Picture in Image control.
            Image_display.ImageUrl = "~/uploads/" + Path.GetFileName(FileUpload_file.FileName);
        }
        //sever side code file download
        protected void Button_download_Click(object sender, EventArgs e)
        {
            
    Response.ContentType = "uploads/jpg";
    Response.AppendHeader("Content-Disposition", "attachment; filename=help.jpg");
    Response.TransmitFile(Server.MapPath("~/uploads/s.jpg"));
     
            Response.End();
        }
    }
}
