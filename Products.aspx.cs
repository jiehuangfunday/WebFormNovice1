using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormNovice1.Models;

namespace WebFormNovice1
{
    public partial class Products : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            
            if (Validation(out List<string> msg))
            {
                try
                {
                    using (var db = new DBModel())
                    {
                        decimal price = decimal.Parse(HttpUtility.HtmlEncode(txtPrice.Text), NumberStyles.AllowDecimalPoint, new NumberFormatInfo() { NumberDecimalSeparator = "," });
                        db.Products.Add(new Models.Product
                        {
                            Name = HttpUtility.HtmlEncode(txtName.Text),
                            Price = price,
                            Description = HttpUtility.HtmlEncode(txtDescription.Text)
                        });
                        db.SaveChanges();
                    }
                }
                catch (Exception ex)
                {
                    Alert($"Add Product Data Error：{ex.Message}");
                }
            }
            else
            {
                Alert(msg);
            }
        }

        private bool Validation(out List<string> msg)
        {
            var result = false;
            msg = new List<string>();
            if (string.IsNullOrEmpty(txtName.Text))
            {
                msg.Add("Pleass Write Produst Name!!");
            }
            if (!decimal.TryParse(txtPrice.Text, NumberStyles.AllowDecimalPoint, new NumberFormatInfo() { NumberDecimalSeparator = "," }, out decimal price))
            {
                msg.Add("Pleass Write Number!!");
            }
            if (string.IsNullOrEmpty(txtDescription.Text))
            {
                msg.Add("Pleass Write Description !!");
            }
            if (!msg.Any())
            {
                result = true;
            }
            return result;
        }
    }
}