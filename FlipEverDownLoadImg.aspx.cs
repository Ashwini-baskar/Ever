using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Web;
using Ionic.Zip;
using System.Web.UI.WebControls;
using System.Threading.Tasks;

namespace FlipEver
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            // Iterate through the images (only files with extension.jpg) in the 'images' folder, and bind them to the Datalist



            ArrayList al = new ArrayList();
            foreach (string file in Directory.GetFiles(Server.MapPath("MediaUpload/")))
            {
                if (Path.GetExtension(file) == ".jpg")
                {
                    al.Add(Path.GetFileName(file));
                }
            }
            DataList1.DataSource = al;
            DataList1.DataBind();


            if (!IsPostBack)
            {
                string[] filePaths = Directory.GetFiles(Server.MapPath("~/img/"));
                List<ListItem> files = new List<ListItem>();
                foreach (string filePath in filePaths)
                {
                    files.Add(new ListItem(Path.GetFileName(filePath), filePath));
                }
                GridView1.DataSource = files;
                GridView1.DataBind();
            }

              }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string src = "D:\\Data\\Project\\Internal\\EmployeePortal\\Application\\EmployeePortalV10\\FlipEver\\FlipEver\\img\\File";
             string dst = @"D:\Files\File";
          string extension = ".txt";
         List<FileItem> files = new List<FileItem>();
        for (int i = 1; i <= 10; i++)
          {
         files.Add(new FileItem { Source = new Uri(src + i.ToString() + extension), Destination = dst + i.ToString() + extension });

        }
         foreach (FileItem fi in files)
          {
        System.Net.WebClient client = new WebClient();
        client.DownloadFileAsync(fi.Source, fi.Destination);
           }
         }

class FileItem

        {
        public Uri Source { get; set; }
        public String Destination { get; set; }
         }

        protected void DownloadFiles(object sender, EventArgs e)
        {
            using (ZipFile zip = new ZipFile())
            {
                zip.AlternateEncodingUsage = ZipOption.AsNecessary;
                zip.AddDirectoryByName("Files");
                foreach (GridViewRow row in GridView1.Rows)
                {
                    if ((row.FindControl("chkSelect") as CheckBox).Checked)
                    {
                        string filePath = (row.FindControl("lblFilePath") as Label).Text;
                        zip.AddFile(filePath, "Files");
                    }
                }
                Response.Clear();
                Response.BufferOutput = false;
                string zipName = String.Format("Zip_{0}.zip", DateTime.Now.ToString("yyyy-MMM-dd-HHmmss"));
                Response.ContentType = "application/zip";
                Response.AddHeader("content-disposition", "attachment; filename=" + zipName);
                zip.Save(Response.OutputStream);
                Response.End();
            }
        }

        //using AsynC method
        protected async void btnUpload_Click(object sender, EventArgs e)
        {

            await UploadFileAsync(FileUpload1, Label1);
            await UploadFileAsync(FileUpload2, Label2);
            await UploadFileAsync(FileUpload3, Label3);
        }

        private async Task UploadFileAsync(FileUpload fileUpload, Label label)
        {
            //await Task.Factory.StartNew(() =>
            //{

            //});
            await Task.Factory.StartNew(() =>
            {
                bool fileOk = false;
                String path = Server.MapPath("~/img/");

                if (fileUpload.HasFile)
                {
                    String fileExtension =
                    System.IO.Path.GetExtension(fileUpload.FileName).ToLower();
                    String[] allowedExtensions =
                        {".gif", ".png", ".jpeg", ".jpg",".txt"};
                    for (int i = 0; i < allowedExtensions.Length; i++)
                    {
                        if (fileExtension == allowedExtensions[i])
                        {
                            fileOk = true;
                        }
                    }

                    if (fileOk)
                    {
                        try
                        {
                            fileUpload.PostedFile.SaveAs(path
                                + fileUpload.FileName);

                            label.Text = "File uploaded!";
                        }
                        catch (Exception ex)
                        {
                            label.Text = label.Text + "File could not be uploaded.";
                        }
                    }
                    else
                    {
                        label.Text = "Cannot accept files of this type.";
                    }
                }


            });
        }
    }
}
   
    
