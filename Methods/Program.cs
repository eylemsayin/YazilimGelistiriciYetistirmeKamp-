namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ProductName = "Elma";
            double Price = 15;
            string Description = "Amasya elması";
            string[] fruits = new string[] { };



            Product product1 = new Product();
            product1.Name = "Elma";
            product1.Price = 15;
            product1.Description = "Amasya elması";


            Product product2 = new Product();
            product2.Name = "Karpuz";
            product2.Price = 15;
            product2.Description = "Diyarbakır karpuzu";

            Product product3 = new Product();
            product3.Name = "İncir";
            product3.Price = 15;
            product3.Description ="Aydın İnciri";

            Product[] products = new Product[] { product1, product2, product3};
            foreach (Product product in products)
            {
                Console.WriteLine(product.Name +" : " + product.Price);
            }

            Console.WriteLine("-----------------------Methods-------------");

            //instance - örnek 
            //encapsulation
            BasketManager basketManager = new BasketManager();
            basketManager.Add(product1);
            basketManager.Add(product2);


            basketManager.Add2("Armut","Yeşil Armut", 12, 3);
            basketManager.Add2("Karpuz","Diyarbakır Karpuzu", 12, 10);
            basketManager.Add2("Elma","Yeşil Elma", 12 , 20);
           

        }
    }
}

//Don't Repeat Yoourself - DRY -  Clean Code - Best Practice