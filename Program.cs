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


        }


    }
}