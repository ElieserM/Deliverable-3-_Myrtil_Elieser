﻿using System;
using System.ComponentModel;

namespace Deliverable__3__Myrtil_Elieser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            while (true)
            {
                Console.Write("Enter an integer number between 1 and 100: ");
                input = int.Parse(Console.ReadLine());

                if (input >= 1 && input <= 100)
                {
                    break;
                }

            }

            Console.Write("Specify the series type: Even or Odd ");
            string series = Console.ReadLine();

            if (series == "Odd")
            {
                Console.WriteLine("You have selected " + series + " series. The number between 0 and " + input + " are:");
                for (int i = 1; i <= input; i = i + 2)
                {
                    Console.WriteLine(i);
                }
            }
            //Test with iteration. for example iteration 0 and 1 would equal to 0 and 2 which corresponds with iteration.
            if (series == "Even")
            {
                Console.WriteLine("You have selected " + series + "series. The number between 0 and " + input + " are:");
                for (int i = 0; i <= input; i = i + 2)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}