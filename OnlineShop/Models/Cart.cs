using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShop.Models
{
	public class Cart
	{
		int CartId, UserId, ProductId, Quantity;
		long Price;
		String ImagePath, ProductName;
		DateTime CartDate;

		public Cart(int cartId, int userId, int productId, int quantity, long price, string imagePath)
		{
			CartId1 = cartId;
			UserId1 = userId;
			ProductId1 = productId;
			Quantity1 = quantity;
			Price1 = price;
			ImagePath1 = imagePath;
		}

		public Cart(int productId, string productName, int quantity, long price, string imagePath)
		{
			ProductId1 = productId;
			ProductName1 = productName;
			Quantity1 = quantity;
			Price1 = price;
			ImagePath1 = imagePath;
		}

		public int CartId1 { get => CartId; set => CartId = value; }
		public int UserId1 { get => UserId; set => UserId = value; }
		public int ProductId1 { get => ProductId; set => ProductId = value; }
		public int Quantity1 { get => Quantity; set => Quantity = value; }
		public long Price1 { get => Price; set => Price = value; }
		public string ImagePath1 { get => ImagePath; set => ImagePath = value; }
		public DateTime CartDate1 { get => CartDate; set => CartDate = value; }
		public string ProductName1 { get => ProductName; set => ProductName = value; }
	}
}