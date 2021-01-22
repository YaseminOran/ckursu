using System;

namespace OOP1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 25;

            ProductManager productManager = new ProductManager();

            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);
            productManager.Update(product1);
            Console.WriteLine(product1.UnitsInStock);




        }
    }
}
