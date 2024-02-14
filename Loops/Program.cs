namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string course1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string course2 = "Programlamaya Başlangıç İçin Temel Kurs";
            string course3 = "Java";
            string course4 = "Python";

            Console.WriteLine(course1);
            Console.WriteLine(course2);
            Console.WriteLine(course3);
            Console.WriteLine(course4);

            Console.WriteLine("---------------------------------");
            //Array - Dizi 

            string[] courses = new string[]
            {
               "Yazılım Geliştirici Yetiştirme Kampı",
               "Programlamaya Başlangıç İçin Temel Kurs",
               "Java",
               "Python",
               "C#",
               "C++"
            };
            for (int i = 0; i < courses.Length; i++)
            {
                Console.WriteLine(courses[i]);

            }
            Console.WriteLine("---------------- For Bitti ------------------");

            foreach (string course in courses) //Kursları dolaş
            {
                Console.WriteLine(course);
            }
        }
    }
}
