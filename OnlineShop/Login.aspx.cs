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
	public partial class Login : System.Web.UI.Page
	{
		Connect connect = new Connect();
		protected void Page_Load(object sender, EventArgs e)
		{
		}

		protected void submit_Click(object sender, EventArgs e)
		{
			if (ktData())
			{
				connect.getConnect();
				SqlCommand cmd = new SqlCommand();
				cmd.CommandText = "select count(*) from Profile where Email = '" + email.Text + "' and Password = '" + password.Text + "'";
				cmd.Connection = connect.cn;
				int kt = -1;
				kt = int.Parse(cmd.ExecuteScalar() + "");
				if (kt == 1)
				{
					SqlCommand cmd3 = new SqlCommand();
					cmd3.CommandText = "select UserId from Profile where Email = '" + email.Text + "'";
					cmd3.Connection = connect.cn;
					int id = int.Parse(cmd3.ExecuteScalar() + "");

					SqlCommand cmd4 = new SqlCommand();
					cmd4.CommandText = "select RoleId from Profile where Email = '" + email.Text + "'";
					cmd4.Connection = connect.cn;
					int roleId = int.Parse(cmd4.ExecuteScalar() + "");
					Session["idUser"] = id;
					if (roleId == 1)
						Response.Redirect("Defaut.aspx");
					else Response.Redirect("QLNguoiDung.aspx");
				}
				else
				{
					kttxt.Text = "Email hoặc Mật khẩu bị sai!";
				}
				connect.cn.Close();
			}
			else
			{
				kttxt.Text = "Vui lòng nhập đầy đủ thông tin!";
			}
		}
		Boolean ktData()
		{
			if (email.Text.Count() <= 0)
				return false;
			else if (password.Text.Count() <= 0)
				return false;
			return true;
		}
	}
}