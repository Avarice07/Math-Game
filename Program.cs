using System.Diagnostics;

namespace Hello_the_world
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name?: ");
            string name = Console.ReadLine();
            var player = new Player(name, 0);

            Console.WriteLine($"Welcome {player.name} to your very own math game!!!");
            //Console.WriteLine($"The Curret time is {DateTime.Now}");
            Console.Write("Press any key to proceed to the Menu Screen");


            Console.Clear();

            Console.WriteLine("Which game would you like to play today? Kindly choose below:");
            Console.WriteLine("A - Addition");
            Console.WriteLine("S - Subtraction");
            Console.WriteLine("M - Multiplication");
            Console.WriteLine("D - Division");
            Console.WriteLine("V - View Past Games");
            Console.WriteLine("------------------------------------------------------------");


        }


    }
}