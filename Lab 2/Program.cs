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
            BoilingWater();
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

    }

}
