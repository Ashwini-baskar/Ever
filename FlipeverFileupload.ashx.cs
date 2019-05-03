using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace FlipEver
{
    /// <summary>
    /// Summary description for FlipeverFileupload
    /// </summary>
    public class FlipeverFileupload : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Write("Hello World");
            try
            {
                string dirFullPath = HttpContext.Current.Server.MapPath("~/MediaUpload/");
                string[] files;
                int numFiles;
                files = System.IO.Directory.GetFiles(dirFullPath);
                numFiles = files.Length;
                numFiles = numFiles + 1;
                string str_image = "";

                foreach (string s in context.Request.Files)
                {
                    HttpPostedFile file = context.Request.Files[s];
                    string fileName = file.FileName;
                    string fileExtension = file.ContentType;

                    if (!string.IsNullOrEmpty(fileName))
                    {
                        fileExtension = Path.GetExtension(fileName);
                        str_image = "MyPHOTO_" + numFiles.ToString() + fileExtension;
                        string pathToSave_100 = HttpContext.Current.Server.MapPath("~/MediaUpload/") + str_image;
                        file.SaveAs(pathToSave_100);


                    }
                }
                //  database record update logic here  ()

                context.Response.Write(str_image);
            }
            catch (Exception ac)
            {

            }

        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}