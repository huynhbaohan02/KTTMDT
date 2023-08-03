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
	public partial class DetailProduct : System.Web.UI.Page
	{
		public string idProduct, idUser;
		public Product product;
		protected void Page_Load(object sender, EventArgs e)
		{
			idProduct = Request.QueryString["idProduct"];
			idUser= Request.QueryString["id"];
			Connect connect = new Connect();
			connect.getConnect();

			string sql3 = "select * from Product where ProductId='"+ idProduct +"'";
			DataTable dtProduct = connect.getData(sql3);
			foreach (DataRow dr in dtProduct.Rows)
			{
				product = new Product(dr["Introduction"] + "", dr["ProductName"] + "",
					dr["ImagePath"] + "", int.Parse(dr["Bought"] + ""), long.Parse(dr["Price"] + ""), int.Parse(dr["ProductId"] + ""));
			}
			connect.cn.Close();
		}
	}
}