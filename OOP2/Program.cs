namespace OOP2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Individual customer1 = new Individual();
            customer1.CustomerNumber = "12345";
            customer1.FirstName = "Eylem";
            customer1.LastName = "Sayın";
            customer1.TcNo = "12345678910";


            //Kodlama.io
            Corporate customer2 = new Corporate();
            customer2.Id = 2;
            customer2.CustomerNumber = "54321";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNo = "1234567890";
            //Gerçek Müşteri - Tüzel Müşteri
            //SOLID 

            Customer customer3 = new Individual(); 
            Customer customer4 = new Corporate();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
        }
    }
}
