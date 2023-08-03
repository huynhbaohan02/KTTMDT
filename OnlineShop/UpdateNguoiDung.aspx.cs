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
	public partial class UpdateNguoiDung : System.Web.UI.Page
	{
		Connect connect = new Connect();
		protected void Page_Load(object sender, EventArgs e)
		{
			
		}

		protected void btnUpdateUser_Click(object sender, EventArgs e)
		{
			if (ktData())
			{
				connect.getConnect();
				string sql = "Update Profile set UserName = '"+ username.Text + "', PassWord='"+ pasword.Text + "', Status='"+ status.Text + "', RoleId="+ ddRoles.SelectedValue + " where UserId="+ Request.QueryString["idUser"].ToString();

				SqlCommand cmd2 = new SqlCommand(sql, connect.cn);
				int kt2 = -1;
				kt2 = int.Parse(cmd2.ExecuteNonQuery() + "");
				connect.cn.Close();
				Response.Redirect("QLNguoiDung.aspx");
			}
		}

		protected void btnBack_Click(object sender, EventArgs e)
		{
			Response.Redirect("QLNguoiDung.aspx");
		}
		Boolean ktData()
		{
			if (pasword.Text.Count() <= 0)
				return false;
			else if (username.Text.Count() <= 0)
				return false;
			return true;
		}
	}
}