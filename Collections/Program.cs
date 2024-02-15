namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] Names = new string[] { "Eylül", "Merve", "Berke", "Derin" };
            //Console.WriteLine(Names[0]);
            //Console.WriteLine(Names[1]);
            //Console.WriteLine(Names[2]);
            //Console.WriteLine(Names[3]);
           

            //Names = new string[5];
            //Names[4] = "İlker";
            //Console.WriteLine(Names[4]);
            //Console.WriteLine(Names[0]);



            List<string> names2 = new List<string>()
            { "Eylül","Merve", "Berke", "Derin"};
            Console.WriteLine(names2[2]);
            names2.Add("İlker");
            Console.WriteLine(names2[4]);





        }
    }
}
