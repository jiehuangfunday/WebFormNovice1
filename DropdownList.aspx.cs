using Dapper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormNovice1.Models;

namespace WebFormNovice1
{
    public partial class DropdownList : BasePage
    {
        private readonly string connectString = @"Server=192.168.11.67;Database=Tutorial;User Id=jiehuang;Password=jiehuang;";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                using (var db = new DBModel())
                {
                    if (!CheckHasData(db))
                    {
                        InsertData(db);
                    }
                    LoadProductCategory(db);
                }
            }
        }
        private bool CheckHasData(DBModel db)
        {
            var result = false;
            try
            {
                result = db.ProductCategorys.Any();
            }
            catch (Exception ex)
            {
                Alert($"CheckHasData Error：{ex.Message}");
            }
            return result;
        }
        private void InsertData(DBModel db)
        {
            try
            {
                db.ProductCategorys.Add(new ProductCategory { Name = "Accessories" });
                db.ProductCategorys.Add(new ProductCategory { Name = "Apparel" });
                db.ProductCategorys.Add(new ProductCategory { Name = "Bicycle Accessories" });
                db.ProductCategorys.Add(new ProductCategory { Name = "Bicycle Parts" });
                db.ProductCategorys.Add(new ProductCategory { Name = "Bicycle Tools" });
                db.ProductCategorys.Add(new ProductCategory { Name = "Bicycle" });
                db.ProductCategorys.Add(new ProductCategory { Name = "Frame" });
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                Alert($"InsertData Error：{ex.Message}");
            }
        }
        private void LoadProductCategory(DBModel db)
        {
            try
            {
                var temp = db.ProductCategorys.ToList();
                var json = JsonConvert.SerializeObject(db.ProductCategorys.ToList());
                ddl1.DataSource = JsonConvert.DeserializeObject<DataTable>(json);
                ddl1.DataValueField = "id";
                ddl1.DataTextField = "name";
                ddl1.DataBind();
            }
            catch (Exception ex)
            {
                Alert($"Load Product Category Data Error：{ex.Message}");
            }

            
        }
    }
}