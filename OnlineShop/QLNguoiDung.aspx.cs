using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace OnlineShop
{
	public partial class Daoashbroad : System.Web.UI.Page
	{
		Connect connect = new Connect();
		
		protected void Page_Load(object sender, EventArgs e)
		{
			getUser();
		}

		

		public void getUser()
		{
			string sql = "select UserId, r.Name as Quyen, p.Username as UserName, p.Email, p.CreateDate, p.Status from Profile as p, Roles as r where p.RoleId = r.RoleId";
			listUser.DataSource = connect.getData(sql); ;
			listUser.DataBind();
		}
		

		protected void listUser_RowDeleting(object sender, GridViewDeleteEventArgs e)
		{
			connect.getConnect();
			Label textBox = (Label)listUser.Rows[e.RowIndex].FindControl("iduser");
			int idUser = textBox != null ? Convert.ToInt32(textBox.Text) : 0;
			string sql = "delete from Profile where UserId='" + idUser + "'";
			SqlCommand cmd = new SqlCommand(sql, connect.cn);
			cmd.ExecuteNonQuery();
			connect.cn.Close();
			getUser();
		}

		protected void LinkButton1_Click(object sender, EventArgs e)
		{
			Response.Write("jdghfhdgf");
			string iduser = ((LinkButton)sender).CommandArgument;
			Response.Redirect("UpdateNguoiDung.aspx?idUser=" + iduser);
		}
	}
}