﻿using System;
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

        static void ForLoop()
        {
            int sum = 0;

            for (int i = 0; i < 10; i++)
            {
                sum += i;
                Console.WriteLine(sum);
            }
            //(1) "int i = 0" kollas först. Sedan "i<10". Sedan går den in i loopen och kör där och allra sist kör den "i++"
            //(2) "int  i = 0" kollas en gång. "i<10" kollas 11 gånger. "i++" kollas 10 gånger och allt inuti loopen körs 10 gånger.
        }

        static void FizzBuzz()
        {
            //Skriv ut 1-100
            //delbara med 3(ingen rest) skriv ut Fizz
            //delbara med 5(ingen rest) skriv ut Buzz
            //delbara med både 3 och 5 skriv ut FizzBuzz (som inte heller lämnar rest antar jag?)

            for (int i = 1; i <= 100; i++)
            {

                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz!");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
               
                else
                {
                    Console.WriteLine(i);
                }
            }
            
        }

        //CardDeck + metod
        #region CardDeck

       
        static void CardDeck()
        {

           
            for (int suit = 1; suit < 5; suit++)
            {
   
                for (int j = 1; j < 14; j++)
                {
                    
                    if (suit == 1)
                    {
                        Console.WriteLine("Hjärter " + FaceCards(j));
                    }
                    else if (suit == 2)
                    {
                        Console.WriteLine("Spader " + FaceCards(j));
                    }
                    else if (suit == 3)
                    {
                        Console.WriteLine("Ruter " + FaceCards(j));
                    }
                    else if (suit == 4)
                    {
                        Console.WriteLine("Klöver " + FaceCards(j));
                    }
                }
            }
            
        }

        //En metod som skriver ut klädda kort med text istället för siffror.
        static string FaceCards(int x)
        {
            string Value = x.ToString();
            
            if (x == 11)
            {
                 Value = "Knekt";
                
            }
            else if (x == 12)
            {
                Value = "Dam";
            }
            else if (x == 13)
            {
                Value = "Kung";
            }
            else if (x == 1)
            {
                Value = "Ess";
            }

            return Value;
           
        }
        #endregion 

        //Fråga 3.1
        //Att använda "while(true)" är riskabelt för att det är stor chans att loopen kommer bli oändlig.
        //(true) sätter inget bra villkor.

        static void Quack()
        {
            Console.WriteLine("Are you a duck?");
            while (Console.ReadLine().ToUpper() == "quack".ToUpper())
            {
                Console.WriteLine("quack quack");
                
            }
            Console.WriteLine("You're not a duck...");
        }

        static void MjauMachine()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("How many Mjaus do you want?");
                    int Mjaus = int.Parse(Console.ReadLine());
                    if (Mjaus != 0)
                    {
                        for (int i = 0; i < Mjaus; i++)
                        {

                            Console.Write("mjau ");

                        }
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine(":(");
                        break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Wrong input!");
                }
     
            }
        }

        static void Part4AnyLoop()
        {

            Console.WriteLine("Number of rows?");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Number of columns?");
            int columns = int.Parse(Console.ReadLine());

            #region Loop A

            //A
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //    {
            //        Console.Write("o");
            //    }
            //    Console.WriteLine();
            //}

            #endregion
            #region Loop B
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //    {
            //        Console.Write("o");

            //    }
            //    Console.WriteLine();
            //    columns--;
            //} 

            #endregion
            #region Loop C
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //    {
            //        if (j % 2 == 0)
            //        {
            //            Console.Write("x");
            //        }
            //        else
            //        {
            //            Console.Write("o");
            //        }
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            #region Loop D
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //    {
            //        if (i %2 != 0)
            //        {
            //            Console.Write("o");
            //        }
            //        else
            //        {
            //            Console.Write("x");
            //        }
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            #region Loop F
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //    {
            //        if (j == i)
            //        {
            //            Console.Write("x");
            //        }
            //        else
            //        {
            //            Console.Write("o");
            //        }

            //    }
            //    Console.WriteLine();

            #endregion
            #region Loop G
            //for (int i = rows; i > 0; i--)
            //{
            //    for (int j = 1; j <= columns; j++)
            //    {
                    
            //        if ( i == j)
            //        {
            //            Console.Write("x");
            //        }
            //        else
            //        {
            //            Console.Write("o");
            //        }

            //    }
            //    Console.WriteLine();
            //}
            #endregion

        }

        }

}
