using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShop.Models
{
	public class ProductCategory
	{
		int CateId;
		string CateName, Icon;

		public ProductCategory(int cateId, string cateName, string icon)
		{
			CateId1 = cateId;
			CateName1 = cateName;
			Icon1 = icon;
		}

		public int CateId1 { get => CateId; set => CateId = value; }
		public string CateName1 { get => CateName; set => CateName = value; }
		public string Icon1 { get => Icon; set => Icon = value; }
	}
}