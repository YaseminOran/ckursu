using System;
namespace OOP1
{
    public class Product
    {
        public int  Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }  //ürünün fiyatı
        public int UnitsInStock { get; set; }//ürünün stok adedi

    }
}
