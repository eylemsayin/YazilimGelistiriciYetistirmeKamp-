using static System.Runtime.InteropServices.JavaScript.JSType;

namespace KampIntro
{
    public class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            string categoryTag = "Kategori";

            int numberOfstudents = 32000;
            double interestRate = 1.45;
            bool haveYouLoggedIntoTheSystem = false;
            double dollarYesterday = 7.35;
            double dollarToday = 7.45;
            if (dollarYesterday> dollarToday)
            {
                Console.WriteLine("Azalış butonu");

            }
            else if(dollarYesterday<dollarToday)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }

            if (haveYouLoggedIntoTheSystem == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(categoryTag);
        }
    }
}
