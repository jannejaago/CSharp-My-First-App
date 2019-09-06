using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("NO HELLO FOR YOU");
            Console.WriteLine("Sup, how may I call you?");
            string name;
            name = Console.ReadLine();
            Console.WriteLine("Fuck off "+name);
            Console.WriteLine("Yo. What year were you born at?");
            int year;
            year = int.Parse(Console.ReadLine());
            int age = 2019 - year;
            Console.WriteLine("You old faggot, " + age + " old");
            Console.ReadLine();
        }
    }
}
