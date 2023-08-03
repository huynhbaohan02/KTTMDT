using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShop.Models
{
	public class CartOrder
	{
		private string phone;
		private string nameUser, statusOrder;

		public CartOrder(string phone, string nameUser, string statusOrder)
		{
			this.Phone = phone;
			this.NameUser = nameUser;
			this.StatusOrder = statusOrder;
		}
		
		public string NameUser { get => nameUser; set => nameUser = value; }
		public string StatusOrder { get => statusOrder; set => statusOrder = value; }
		public string Phone { get => phone; set => phone = value; }
	}
}