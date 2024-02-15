namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Kitap";
            product1.UnitPrice = 150.00;
            product1.UnitInStock = 300;


            Product product2 = new Product { Id = 2, CategoryId = 5, ProductName = "Kalem", UnitPrice = 35.00, UnitInStock = 5 };

            //PascalCase   camelCase
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            productManager.Update(product1);

            Console.WriteLine(product1.ProductName);
           // productManager.Sum2(6, 3);






        }
    }
}
