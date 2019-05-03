using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FlipEver
{
    public partial class FlipEverLogin1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //sever side code
        protected void btnUpload_Click(object sender, EventArgs e)
        {
            if (FileUpload_bt.HasFile)  //fileupload control contains a file  
                try
                {
                    FileUpload_bt.SaveAs("D://Data//Project//Internal//EmployeePortal//Application//EmployeePortalV10//FlipEver//FlipEver//uploads//" + FileUpload_bt.FileName);          // file path where you want to upload  
                   
                }
                catch (Exception ex)
                {
                    ex.Message.ToString();
                }
            else
            {
                Response.Write("Please select a file to upload.");
            }
        }

    }
    }
