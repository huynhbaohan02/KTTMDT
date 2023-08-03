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
	public partial class Home : System.Web.UI.MasterPage
	{
		public int isauth;
		protected void Page_Load(object sender, EventArgs e)
		{
			if (Session["idUser"] != null)
			{
				isauth = 1;
			}
			else isauth = -1;
		}
	}
}