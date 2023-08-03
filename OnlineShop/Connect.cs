using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;


namespace OnlineShop
{
	
	public class Connect : System.Web.UI.Page
	{
		public SqlConnection cn;
		public void getConnect()
		{
			cn = new SqlConnection();
			cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Server.MapPath("App_Data/shop.mdf") + ";Integrated Security=True";
			cn.Open();
		}

		public DataTable getData(String sql)
		{
			DataTable dt = new DataTable();
			try
			{
				getConnect();
				SqlDataAdapter da = new SqlDataAdapter(sql, cn);
				da.Fill(dt);
			}
			catch
			{
				dt = null;
			}
			finally
			{
				cn.Close();
			}
			return dt;	 
		}
		
	}
}