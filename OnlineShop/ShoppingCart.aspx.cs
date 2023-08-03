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
	public partial class ShoppingCart : System.Web.UI.Page
	{
		public String idUser;
		Connect connect = new Connect();
		public List<Cart> listCart = new List<Cart>();
		public List<Product> listProduct = new List<Product>();
		public Product product;
		public Cart cart;
		long tong = 0;
		protected void Page_Load(object sender, EventArgs e)
		{
			idUser = Session["idUser"] + "";
			if (IsPostBack) return;
			if (Session["idUser"] != null)
			{
				if (int.Parse(idUser) > 0)
				{
					connect.getConnect();
					addProduct();
					loadData();
					setMoney();
					connect.cn.Close();
				}
				else
				{
					Response.Redirect("Login.aspx");
				}
			}
			else
			{
				Response.Redirect("Login.aspx");
			}
		}

		public void setMoney()
		{
			string sqlPrice = "select * from Cart where UserId='"+idUser+"'";
			DataTable dt = connect.getData(sqlPrice);
			foreach(DataRow dr in dt.Rows)
			{
				tong += int.Parse(dr["Price"]+"");
			}
			tien.Text = "Tổng tiền phải thanh toán: " + tong + "đ";
		}

		public void loadData()
		{
			string sql = "select p.ProductId, p.ProductName, p.ImagePath, p.Price, c.Quantity, c.Price as PriceSum from Cart as c, Product as p where UserId='" + idUser + "' and c.ProductId=p.ProductId";
			DataTable dt = connect.getData(sql);
			GridView1.DataSource = dt;
			GridView1.DataBind();
		}
		public void addProduct()
		{
			if (Request.QueryString["idProduct"] != null)
			{
				string sql2 = "select * from Product where ProductId='" + Request.QueryString["idProduct"] + "'";
				DataTable dtProduct = connect.getData(sql2);
				foreach (DataRow dr in dtProduct.Rows)
				{
					product = new Product(dr["Introduction"] + "", dr["ProductName"] + "",
						dr["ImagePath"] + "", int.Parse(dr["Bought"] + ""), long.Parse(dr["Price"] + ""), int.Parse(dr["ProductId"] + ""));
				}

				//Response.Write(product.ImagePath+"");
				connect.cn.Open();
				SqlCommand cmd3 = new SqlCommand();
				cmd3.CommandText = "select count(*) from Cart where ProductId='"+ Request.QueryString["idProduct"] + "' and UserId='"+idUser+"'";
				cmd3.Connection = connect.cn;
				int kt3 = -1;
				kt3 = int.Parse(cmd3.ExecuteScalar() + "");
				//Response.Write(kt3);

				if(kt3 == 1)
				{
					/*Lấy Quantity của sản phẩm đã thêm vào trước đó*/
					string sql4 = "select * from Cart where ProductId='" + Request.QueryString["idProduct"] + "' and UserId='" + idUser + "'";
					
					DataTable dtCart = connect.getData(sql4);
					foreach (DataRow dr in dtCart.Rows)
					{
						cart = new Cart(int.Parse(dr["CartId"] + ""),
							int.Parse(dr["UserId"] + ""),
							int.Parse(dr["ProductId"] + ""),
							int.Parse(dr["Quantity"] + ""),
							long.Parse(dr["Price"] + ""),
							dr["ImagePath"] + "");
					}

					/*Cập nhập lại Quantity và giá cho sản phẩm đó*/
					connect.cn.Open();
					SqlCommand cmd2 = new SqlCommand();
					cmd2.CommandText = "Update Cart set Quantity='"+(cart.Quantity1+1)+"', Price='"+(cart.Price1+product.Price)+"' where  ProductId='" + Request.QueryString["idProduct"] + "' and UserId='" + idUser + "'";
					cmd2.Connection = connect.cn;
					int kt2 = -1;
					kt2 = int.Parse(cmd2.ExecuteNonQuery() + "");
					//Response.Write(kt2);
				}
				else
				{
					/*Thêm sản phẩm mới vào giỏ hàng*/
					SqlCommand cmd2 = new SqlCommand();
					cmd2.CommandText = "insert into Cart(ProductId, UserId, Quantity, ImagePath, Price, CartDate) values('" + product.ProductId + "', '" + idUser + "',1 ,'" + product.ImagePath + "' ,'" + product.Price + "' , GETDATE())";
					cmd2.Connection = connect.cn;
					int kt2 = -1;
					kt2 = int.Parse(cmd2.ExecuteNonQuery() + "");
					connect.cn.Close();
				}
			}
		}

		protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
		{
			connect.getConnect();
			string sql = "delete from Cart where UserId='"+idUser+"' and ProductId=@ProductId";
			SqlCommand cmd = new SqlCommand(sql, connect.cn);
			Label textBox = (Label)GridView1.Rows[e.RowIndex].FindControl("idPro");
			int productId = textBox != null ? Convert.ToInt32(textBox.Text) : 0;
			cmd.Parameters.AddWithValue("@ProductId", productId);
			int kt = int.Parse(cmd.ExecuteNonQuery()+"");
			Response.Write(kt + "");
			connect.cn.Close();
			Response.Redirect("~/ShoppingCart.aspx");
		}

		protected void thanhToan_Click(object sender, EventArgs e)
		{
			//if(listCart.Count>0)
				Response.Redirect("~/Checkout.aspx");
		}

		protected void btn_Sua_Click(object sender, EventArgs e)
		{
			connect.getConnect();
			string masp = ((LinkButton)sender).CommandArgument;
			LinkButton sua = ((LinkButton)sender);
			GridViewRow item = (GridViewRow)sua.NamingContainer;
			TextBox tb = (TextBox)item.FindControl("txt_Sl");
			string sl = tb.Text;

			/*Lấy giá của sản phẩm đó*/
			string sqlGia = "select Price from Product where ProductId="+masp;
			SqlCommand cmdGia = new SqlCommand(sqlGia, connect.cn);
			float gia = float.Parse(cmdGia.ExecuteScalar()+"");

			/*Update cart*/
			float tien = int.Parse(sl) * gia;
			string sql = "update Cart set Quantity=" + sl + ", Price="+tien+"  where UserId=" + idUser + " and ProductId="+masp;
			SqlCommand cmd = new SqlCommand(sql, connect.cn);
			int kt = int.Parse(cmd.ExecuteNonQuery() + "");
			loadData();
			setMoney();
		}
		
	}
}