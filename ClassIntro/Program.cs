namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Engin";
            string age = "36";

            Course course1 = new Course();
            course1.Id = 1;
            course1.CourseName = "C#";
            course1.Instructor = "Engin Demiroğ";
            course1.ViewingRate = 68;


            Course course2 = new Course();
            course2.Id = 2;
            course2.CourseName = "java";
            course2.Instructor = "Kerem Varış";
            course2.ViewingRate = 64;


            Course course3 = new Course();
            course3.Id = 2;
            course3.CourseName = "Python";
            course3.Instructor = "Berkay Bilgin";
            course3.ViewingRate = 80;

            Course course4 = new Course();
            course4.Id = 2;
            course4.CourseName = "C++";
            course4.Instructor = "Murat KurtBoğan";
            course4.ViewingRate = 100;


            //Console.WriteLine(course1.CourseName + " : " +course1.Instructor);
            Course[] courses = new Course[]
            {
                course1,
                course2,
                course3,
                course4
            };
            foreach (var course in courses)
            {
                Console.WriteLine(course.CourseName +" : " + course.Instructor);
            }

            
        }
    }
    class Course
    {
        public int Id { get; set; }
        public  string CourseName { get; set; }
        public string Instructor { get; set; }
        public int ViewingRate { get; set; } //Kursun izlenme oranı
    }
}
