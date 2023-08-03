using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineShop
{
	public partial class QLDonHang : System.Web.UI.Page
	{
		Connect connect = new Connect();
		protected void Page_Load(object sender, EventArgs e)
		{
			getOrder();
		}
		public void getOrder()
		{
			string sql = "select p.ProductName, c.ProductId, c.OrderId, c.NameUser, c.price, c.ImagePath, c.Quantity, c.StatusOrder, c.Province, c.AddressDetail, c.Phone, c.Wards, c.District, c.OrderDate from CartOrder as c, Product as p where c.ProductId=p.ProductId";
			ListDonHang.DataSource = connect.getData(sql); ;
			ListDonHang.DataBind();
		}

		protected void suaDonHang_Click(object sender, EventArgs e)
		{
			string idDonHang = ((LinkButton)sender).CommandArgument;
			Response.Redirect("UpdateDonHang.aspx?idDonHang=" + idDonHang);
		}
	}
}