using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using OnlineShop.Models;

namespace OnlineShop
{
	public partial class Checkout : System.Web.UI.Page
	{
		Connect connect = new Connect();
		public float tien = 0;
		string idUser;
		public List<Cart> listCart;
		protected void Page_Load(object sender, EventArgs e)
		{
			idUser = Session["idUser"] + "";
			getCart();
			setMoney();
		}

		private void getCart()
		{
			listCart = new List<Cart>();
			connect.getConnect();
			string idUser = Session["idUser"] + "";
			string sql = "select p.ProductId as ProductId, p.ProductName as ProductName, p.ImagePath as ImagePath, c.Quantity as Quantity, c.Price as Price from Cart as c, Product as p where UserId = '" + idUser + "' and c.ProductId = p.ProductId";
			DataTable dt = connect.getData(sql);
			foreach (DataRow dr in dt.Rows)
			{
				listCart.Add(new Cart(
							int.Parse(dr["ProductId"] + ""),
							dr["ProductName"]+"",
							int.Parse(dr["Quantity"] + ""),
							long.Parse(dr["Price"] + ""),
							dr["ImagePath"] + ""));
			}
		}
		public void setMoney()
		{
			string sqlPrice = "select * from Cart where UserId='"+ idUser + "'";
			DataTable dt = connect.getData(sqlPrice);
			foreach (DataRow dr in dt.Rows)
			{
				tien += int.Parse(dr["Price"] + "");
			}
			tien = tien + 50000;
			
		}

		protected void btn_thanhtoan_Click(object sender, EventArgs e)
		{
			if (ktData())
			{
				connect.getConnect();
				int kt=-1;

				//Thêm product vào đơn hàng
				for (int i = 0; i < listCart.Count; i++)
				{
					string sql = "insert into CartOrder(UserId, ProductId, price, ImagePath, Quantity, StatusOrder, OrderDate, Province, AddressDetail, District, Wards, Phone, NameUser)"+
						"values(" + idUser + ", " + listCart[i].ProductId1 + ", " + listCart[i].Price1 + ",'" + listCart[i].ImagePath1 + "', " + listCart[i].Quantity1 + 
						", N'Đang chờ', GETDATE(), N'"+tinh.Text+ "', N'" + chitiet.Text + "', N'" + huyen.Text + "', N'" + xa.Text + "', '" + sdt.Text + "', N'" + name.Text + "')";
					SqlCommand cmdOrder = new SqlCommand(sql, connect.cn);
					cmdOrder.ExecuteNonQuery();
				}

				//Xóa khỏi giỏ hàng
				string sql2 = "delete from Cart where UserId="+idUser;
				SqlCommand cmdDeCart = new SqlCommand(sql2, connect.cn);
				cmdDeCart.ExecuteNonQuery();
				connect.cn.Close();
				Response.Redirect("DonHang.aspx");
			}
			else
			{
				tb.Text = "Vui lòng nhập đầy đủ thông tin nhận hàng";
			}
		}

		Boolean ktData()
		{
			if (name.Text.Count() <= 0)
				return false;
			else if (sdt.Text.Count() <= 0)
				return false;
			else if (tinh.Text.Count() <= 0)
				return false;
			else if (huyen.Text.Count() <= 0)
				return false;
			else if (xa.Text.Count() <= 0)
				return false;
			else if (chitiet.Text.Count() <= 0)
				return false;
			return true;
		}
	}
}