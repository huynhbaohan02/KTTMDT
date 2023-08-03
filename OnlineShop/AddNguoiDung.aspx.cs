using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace OnlineShop
{
	public partial class AddNguoiDung : System.Web.UI.Page
	{
		Connect connect = new Connect();
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void btnBack_Click(object sender, EventArgs e)
		{
			Response.Redirect("QLNguoiDung.aspx");
		}

		protected void btnAddUser_Click(object sender, EventArgs e)
		{
			if (ktData())
			{
				connect.getConnect();
				int kt;
				SqlCommand cmd = new SqlCommand();
				cmd.CommandText = "select count(*) from Profile where Email = '" + email.Text + "'";
				cmd.Connection = connect.cn;
				kt = int.Parse(cmd.ExecuteScalar() + "");
				if (kt > 0)
				{
					kttxt.Text = "Email này đã được đăng kí rồi!";
				}
				else
				{
					string sql = "insert into Profile(Username, Email, RoleId, Password, CreateDate, Status) values(N'" + username.Text + "', '" + email.Text + "', '" + ddRoles.SelectedValue + "', '" + pasword.Text + "', GETDATE(),N'" + status.Text + "')";
					Response.Write(sql);
					SqlCommand cmd2 = new SqlCommand(sql, connect.cn);
					int kt2 = -1;
					kt2 = int.Parse(cmd2.ExecuteNonQuery() + "");
					connect.cn.Close();
					Response.Redirect("QLNguoiDung.aspx");
				}
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
			else if (pasword.Text.Count() <= 0)
				return false;
			else if (username.Text.Count() <= 0)
				return false;
			return true;
		}
	}
}