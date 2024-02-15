namespace GenericsIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<string> names = new MyList<string>();
            names.Add("Eylem");

            //List<string> list = new List<string>();
            //Console.WriteLine(list.Count);

            Console.WriteLine(names.Length);
            names.Add("Kerem");

            Console.WriteLine(names.Length);

            foreach (var name in names.Items)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("Hello, World!");
        }
    }
}
