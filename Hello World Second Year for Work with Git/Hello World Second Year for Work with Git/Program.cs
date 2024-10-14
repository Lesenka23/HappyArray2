using System.Threading.Channels;

namespace Hello_World_Second_Year_for_Work_with_Git
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World! ");
            Console.WriteLine("Hello, Second Year! ");
            Console.WriteLine("What is your name");
            string name = Console.ReadLine();
            Console.WriteLine("What is your age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is your specialization");
            string specialization = Console.ReadLine();
            ItGroup secondYear = new ItGroup( name, age, specialization);
            secondYear.PrintInfo();

            Console.ReadKey();
        }
    }
}
