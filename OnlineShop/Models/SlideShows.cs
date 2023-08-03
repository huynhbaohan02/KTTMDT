using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShop.Models
{
	public class SlideShows
	{
		int Id;
		string ImagePath, Link;
		public SlideShows() { }
		public SlideShows(int id, string imagePath, string link)
		{
			Id = id;
			ImagePath = imagePath;
			Link = link;
		}

		public int Id1 { get => Id; set => Id = value; }
		public string ImagePath1 { get => ImagePath; set => ImagePath = value; }
		public string Link1 { get => Link; set => Link = value; }
	}
}