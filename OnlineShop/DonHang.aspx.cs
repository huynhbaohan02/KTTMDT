using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OnlineShop.Models;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineShop
{
	
	public partial class DonHang : System.Web.UI.Page
	{
		Connect connect = new Connect();
		protected void Page_Load(object sender, EventArgs e)
		{
			getDonHang();
		}

		private void getDonHang()
		{
			if(Session["idUser"] != null)
			{
				string sql = "select p.ProductName, c.ProductId, c.OrderId, c.NameUser, c.price, c.ImagePath, c.Quantity, c.StatusOrder, c.Province, c.AddressDetail, c.Phone, c.Wards, c.District, c.OrderDate from CartOrder as c, Product as p where c.ProductId=p.ProductId and UserId="+Session["idUser"].ToString();
				GridView1.DataSource = connect.getData(sql);
				GridView1.DataBind();
			}
			else
			{
				Response.Redirect("Login.aspx");
			}
			
		}
	}
}