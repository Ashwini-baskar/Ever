using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace FlipEver
{
    /// <summary>
    /// Summary description for DownloadFilehandler
    /// </summary>
    public class DownloadFilehandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string file = context.Request.QueryString["file"];

            if (!string.IsNullOrEmpty(file) && File.Exists(context.Server.MapPath(file)))
            {
                context.Response.Clear();
                context.Response.ContentType = "application/octet-stream";
                context.Response.AddHeader("content-disposition", "attachment;filename=" + Path.GetFileName(file));
                context.Response.WriteFile(context.Server.MapPath(file));
                // This would be the ideal spot to collect some download statistics and / or tracking  
                // also, you could implement other requests, such as delete the file after download  
                context.Response.End();

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