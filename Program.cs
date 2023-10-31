using System;
using System.Diagnostics;
using static System.Formats.Asn1.AsnWriter;
using System.Text;

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
               
                bool t = true;

                while (t) {
                    char option = Console.ReadKey(true).KeyChar;
                    if (option == 'A' || option == 'a')
                    {
                        MathRound(1);
                        t = false;
                        AnyKey(1);
                        Menu();


                    }
                    else if (option == 'S' || option == 's')
                    {
                        MathRound(2);
                        t = false;
                        AnyKey(1);
                        Menu();


                    }
                    else if (option == 'M' || option == 'm')
                    {
                        MathRound(3);
                        t = false;
                        AnyKey(1);
                        Menu();


                    }
                    else if (option == 'S' || option == 's')
                    {
                        MathRound(4);
                        t = false;
                        AnyKey(1);
                        Menu();


                    }
                    else if (option == 'V' || option == 'v')
                    {   
                        Console.Clear();
                        Console.WriteLine("          ***Players Game Record***");
                        Console.WriteLine("-----------------------------------------------");
                        foreach (Record r in player.playerRecord) {
                           Console.WriteLine($"Played at {r.date} with a score of {r.points} points");
                        }
                        Console.WriteLine("-----------------------------------------------");
                        Console.WriteLine($"The total score for {player.name} is {player.score}");
                        AnyKey(1);
                        Menu();
                    }
                    else if (option == 'Q' || option == 'q') 
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Error unknown command, Please try again!!!");
                    }

                }

            }

            void MathRound(int o)
            {
                
                Random a = new Random();
                int round = 0;
                int score = 0;
                while (round < 5)
                {
                    Console.Clear();
                    int x = a.Next(101);
                    int y = a.Next(101);
                    Console.WriteLine($"{x} {OpChoice(o)} {y} = ?");
                    try
                    {
                        int answer = int.Parse(Console.ReadLine().Trim());

                        if (answer == OpCond(o, x, y))
                        {
                            Console.WriteLine("Correct!!!");
                            score += 1;
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
                player.playerRecord.Add(new Record(score, DateTime.Now));
                Console.WriteLine($"You got {score} out of the 5 correct!!!");
                player.score += score;

            }

            string OpChoice(int o) {

                switch (o)
                {
                    case 1:
                        return "+";
                    case 2:
                        return "-";
                    case 3:
                        return "*";
                    case 4:
                        return "/";
                    default:
                        return " ";
                }
                    
           }

            int OpCond(int o,int x,int y)
            {

                switch (o)
                {
                    case 1:
                        return x + y;
                    case 2:
                        return x - y;
                    case 3:
                        return x * y;
                    case 4:
                        return x / y;
                    default:
                        return 0;
                }

            }

            void Menu() 
            {
                Console.WriteLine($"Which game would you like to play today {player.name}? Kindly choose below:");
                Console.WriteLine("A - Addition");
                Console.WriteLine("S - Subtraction");
                Console.WriteLine("M - Multiplication");
                Console.WriteLine("D - Division");
                Console.WriteLine("V - View Past Games");
                Console.WriteLine("Q - To quit");
                Console.WriteLine("------------------------------------------------------------");

                OptionKey();

            }
            
            Console.Clear();
            Console.WriteLine($"Welcome {player.name} to your very own math game!!!");
            //Console.WriteLine($"The Curret time is {DateTime.Now}");
            Console.Write("Press any key to proceed to the Menu Screen");
            AnyKey(0);
            Menu();
           
            

           

        }


    }
}