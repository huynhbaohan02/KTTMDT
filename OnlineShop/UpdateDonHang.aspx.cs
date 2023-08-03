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
	public partial class UpdateDonHang : System.Web.UI.Page
	{
		CartOrder order;
		Connect connect = new Connect();
		protected void Page_Load(object sender, EventArgs e)
		{
			if (IsPostBack) return;
			connect.getConnect();
			string sql = "select * from CartOrder where OrderId=" + Request.QueryString["idDonHang"].ToString();
			DataTable dt = connect.getData(sql);
			foreach (DataRow dr in dt.Rows)
			{
				order = new CartOrder(dr["Phone"] + "", dr["NameUser"] + "", dr["StatusOrder"] + "");
			}
			sdt.Text = order.Phone;
			name.Text = order.NameUser;
			status.Text = order.StatusOrder;
		}

		protected void btnUpdateDonHang_Click(object sender, EventArgs e)
		{
			connect.getConnect();
			string sql = "Update CartOrder set NameUser = N'" + name.Text + "', StatusOrder=N'" + status.Text + "', Phone='" + sdt.Text + "' where OrderId=" + Request.QueryString["idDonHang"].ToString();
			SqlCommand cmd2 = new SqlCommand(sql, connect.cn);
			int kt2 = -1;
			kt2 = int.Parse(cmd2.ExecuteNonQuery() + "");
			connect.cn.Close();
			Response.Redirect("QLDonHang.aspx");

		}

		protected void btnBack_Click(object sender, EventArgs e)
		{
			Response.Redirect("QLDonHang.aspx");
		}
	}
}