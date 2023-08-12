using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShop.Models
{
    public class Product
    {
        int categoryId, supplierId, productId, bought, lnStock, onOrder;
        string productName, imagePath, parameters, introduction, information;
        long price;

        public Product(string introduction, string productName, string imagePath, long price)
        {
            this.introduction = introduction;
            this.productName = productName;
            this.imagePath = imagePath;
            this.price = price;
        }

        public Product(string introduction, string productName, string imagePath, int bought, long price, int productId)
        {
            this.introduction = introduction;
            this.productName = productName;
            this.imagePath = imagePath;
            this.bought = bought;
            this.price = price;
            this.productId = productId;
        }

        public int CategoryId { get => categoryId; set => categoryId = value; }
        public int SupplierId { get => supplierId; set => supplierId = value; }
        public int ProductId { get => productId; set => productId = value; }
        public string Introduction { get => introduction; set => introduction = value; }
        public string ProductName { get => productName; set => productName = value; }
        public string ImagePath { get => imagePath; set => imagePath = value; }
        public string Parameters { get => parameters; set => parameters = value; }
        public int LnStock { get => lnStock; set => lnStock = value; }
        public int OnOrder { get => onOrder; set => onOrder = value; }
        public int Bought { get => bought; set => bought = value; }
        public long Price { get => price; set => price = value; }
        public string Information { get => information; set => information = value; }
    }
}