using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
          
        }
        static void BoilingWater()
        {
            //Uppgift 1.1
            int WaterDegrees = Convert.ToInt32(Console.ReadLine());
            if (WaterDegrees == 100)
            {
                Console.WriteLine("Water is boiling!");
            }
            else if (WaterDegrees == 50)
            {
                Console.WriteLine("Boiling soon!");
            }
            else
            {
                Console.WriteLine("I'ts not boiling");
            }

            //Fråga 1.1
            // Vad är det för skillnad med att skriva = och ==? När använder vi = och när
            //använder ==? 

            //'=' tecknet används när man tilldelar värden tex 'sum = 5'. '==' används för att kolla ett villkor tex 'if (input == 5), gör detta..'
        }

        static void PonyRiding()
        {
            int Age, Weight;

            Console.WriteLine("What is your age?");
            Age = Convert.ToInt32(Console.ReadLine());

            if (Age < 12)
            {
                Console.WriteLine("You are too young to compete");
            }
            else if (Age > 12)
            {
                Console.WriteLine("What is your weight");
                Weight = Convert.ToInt32(Console.ReadLine());
                if (Weight <= 30)
                {
                    Console.WriteLine("A-pony");
                }
                else if (Weight <= 50 && Weight > 30 )
                {
                    Console.WriteLine("B-pony");
                }
                else if (Weight <= 65 && Weight > 50 )
                {
                    Console.WriteLine("C-Pony");
                }
                else
                {
                    Console.WriteLine("There are no ponys for this weight class");
                }
            }
        }

        static void Bath()
        {
            

            Console.WriteLine("Is there water?");
            string IsThereWater = Console.ReadLine();

            Console.WriteLine("How many degrees is the water?");
            int WaterDegree = Convert.ToInt32(Console.ReadLine());

            if (IsThereWater == "yes" && WaterDegree >= 30)
            {
                Console.WriteLine("You can take a bath!");
            }
            else if (IsThereWater == "no" || WaterDegree < 30)
            {
                Console.WriteLine("You can't take a bath");
            }


            //Denna versionen frågar inte efter grader om IsThereWater är "nej".

            //Console.WriteLine("Is there water?");
            //string IsThereWater = Console.ReadLine();

            //if (IsThereWater == "yes")
            //{
            //    Console.WriteLine("How many degrees is the water?");
            //    int WaterDegree = Convert.ToInt32(Console.ReadLine());

            //    if (WaterDegree >= 30)
            //    {
            //        Console.WriteLine("You can take a bath");
            //    }
            //    else
            //    {
            //        Console.WriteLine("You can't take a bath");
            //    }
            //}
            //else 
            //{
            //    Console.WriteLine("You can't take a bath");
            //}

        }

    }

}
