using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormNovice1
{
    public partial class UploadImage : BasePage
    {
        private readonly List<string> ImgExtensionNames = new List<string> { ".bmp", ".gif", ".ico", ".jpg", ".jpeg", ".png", ".tif", ".tiff", ".wmf" };
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void btnUpload_Click(object sender, EventArgs e)
        {
            if (Validation(out List<string> msg))
            {
                image.ImageUrl = "data:image;base64," + Convert.ToBase64String(fileUpload.FileBytes);
            }
            else
            {
                Alert(msg);
                image.ImageUrl = "";
                image.Dispose();
            }
        }
        private bool Validation(out List<string> msg)
        {
            var result = false;
            msg = new List<string>();

            if (fileUpload.HasFile)
            {
                string fileExtensionName = Path.GetExtension(fileUpload.FileName);

                if (!ImgExtensionNames.Contains(fileExtensionName.ToLower()))
                {
                    msg.Add("Pleass Image File");
                }
            }
            else
            {
                msg.Add("Pleass Select File");
            }

            if (!msg.Any())
            {
                result = true;
            }
            return result;
        }
    }
}