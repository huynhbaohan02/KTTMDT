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
	public partial class SignUp : System.Web.UI.Page
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
                    string insertQuery = "INSERT INTO Profile (Username, Email, Password, RoleId, CreateDate, Status) VALUES (@Username, @Email, @Password, @RoleId, GETDATE(), @Status)";
                    SqlCommand cmd2 = new SqlCommand(insertQuery, connect.cn);       
                    cmd2.Parameters.AddWithValue("@Username", username.Text);
                    cmd2.Parameters.AddWithValue("@Email", email.Text);
                    cmd2.Parameters.AddWithValue("@Password", password.Text);
                    cmd2.Parameters.AddWithValue("@RoleId", 1); // Thay 1 bằng giá trị tương ứng của 'Mở' trong cơ sở dữ liệu.
                    cmd2.Parameters.AddWithValue("@Status", "Mở"); // Chú ý đặt giá trị trong dấu ngoặc kép.

                    int kt2 = -1;
					kt2 = int.Parse(cmd2.ExecuteNonQuery() + "");
					
					if (kt2 > 0)
					{
						SqlCommand cmd3 = new SqlCommand();
						cmd3.CommandText = "select UserId from Profile where Email = '" + email.Text + "'";
						cmd3.Connection = connect.cn;
						int id = int.Parse(cmd3.ExecuteScalar() + "");
						//Const.Isauth = id;
						Session["idUser"] = id;
						Response.Redirect("Defaut.aspx");
					}
					else
					{
						kttxt.Text = "Lỗi đăng kí!";
					}
					connect.cn.Close();
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
			else if (password.Text.Count() <= 0)
				return false;
			else if (username.Text.Count() <= 0)
				return false;
			return true;
		}
	}
}