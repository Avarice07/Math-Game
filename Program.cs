using System.Diagnostics;

namespace Hello_the_world
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anung pangalan mo Yawa??: ");
            const double pi = Math.PI;
                string word = Console.ReadLine();
                if (word == "Ann")
                {
                    Console.WriteLine("Apaka Ambot mo " + word+ "!!!!");
                } else if (word=="Victor"){
                    Console.WriteLine("Ang pogi mo " + word);
                }
                else {
                    Console.WriteLine("Cnu ka " + word +"??");
               }

        }


    }
}