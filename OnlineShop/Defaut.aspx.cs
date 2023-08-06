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
	public partial class Defaut : System.Web.UI.Page
	{
		Connect connect = new Connect();
		public List<SlideShows> arrList = new List<SlideShows>();
		public List<Product> arrProduct = new List<Product>();
		public String idUser;
		string maloai = "";
		protected void Page_Load(object sender, EventArgs e)
		{
			if (Session["idUser"] != null)
				idUser = Session["idUser"]+"";
			else idUser = "0";
			if (IsPostBack) return;
			connect.getConnect();
			string sql = "select * from SlideShows";
			DataTable dt = connect.getData(sql);
			foreach (DataRow dr in dt.Rows)
			{
				arrList.Add(new SlideShows(int.Parse(dr["Id"]+""), dr["ImagePath"]+"", dr["Link"]+""));
			}

			string sql2 = "select * from ProductCategory";
			DataList1.DataSource = connect.getData(sql2);
			DataList1.DataBind();

			getProduct();
		}

		protected void getProduct()
		{
			string sql3;
			if (maloai != "")
			{
				sql3 = "select * from Product where CateId='" + maloai + "'";
			}
			else
			{
				sql3 = "select * from Product";
			}
			DataTable dtProduct = connect.getData(sql3);
			arrProduct.Clear();
			foreach (DataRow dr in dtProduct.Rows)
			{
				arrProduct.Add(new Product(dr["Introduction"] + "", dr["ProductName"] + "",
					dr["ImagePath"] + "", int.Parse(dr["Bought"] + ""), long.Parse(dr["Price"] + ""), int.Parse(dr["ProductId"] + "")));
			}
		}

		
	}
}