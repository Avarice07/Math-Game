using System.Diagnostics;

namespace Hello_the_world
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void AnyKey(int m)
            {
                if (m == 1) 
                {
                    Console.WriteLine("Press any key to continue...");
                
                }
                    
                Console.ReadKey();
                Console.Clear();

                
            }

            Console.Write("What is your name?: ");
            string name = Console.ReadLine();
            var player = new Player(name, 0);

            void OptionKey()
            {   
                Random a = new Random();
                bool t = true;
                int round = 0;

                while(t) {
                    char option = Console.ReadKey(true).KeyChar;
                    if (option == 'A' || option == 'a')
                    {
                        while (round < 6)
                        {
                            Console.Clear();
                            int x = a.Next(101);
                            int y = a.Next(101);
                            Console.WriteLine($"{x} + {y} = ?");
                            try
                            {
                                int answer = int.Parse(Console.ReadLine().Trim());
                                if (answer == x + y)
                                {
                                    Console.WriteLine("Correct!!!");
                                    player.score += 1;
                                    AnyKey(1);

                                }
                                else 
                                {
                                    Console.WriteLine("Wrong Answer!!");
                                    AnyKey(1);
                                
                                }
                                
                            }
                            catch (Exception e) 
                            {
                                Console.WriteLine("Wrong Value");
                                AnyKey(1);
                            }
                            round += 1;


                        }
                        
                        t= false;


                    }
                    else
                    {
                        Console.WriteLine("Error unknown command, Please try again!!!");
                    }

                }


                
               



            }

            

            Console.WriteLine($"Welcome {player.name} to your very own math game!!!");
            //Console.WriteLine($"The Curret time is {DateTime.Now}");
            Console.Write("Press any key to proceed to the Menu Screen");
            AnyKey(0);

            Console.WriteLine($"Which game would you like to play today {player.name}? Kindly choose below:");
            Console.WriteLine("A - Addition");
            Console.WriteLine("S - Subtraction");
            Console.WriteLine("M - Multiplication");
            Console.WriteLine("D - Division");
            Console.WriteLine("V - View Past Games");
            Console.WriteLine("------------------------------------------------------------");

            OptionKey();
            

           

        }


    }
}