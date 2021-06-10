﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Create list to store each DIGIT
            List<int> number = new List<int>();

            //Receive 9 DIGITS
            Console.WriteLine("\nEnter 9 digits number: ");
            do
            {
                int addNum = 1;

                try
                {
                    addNum = Int32.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Please don't enter null\n");
                    return;
                }
             
                if (0 < addNum && addNum <= 9)
                {
                    number.Add(addNum);
                }
                else
                {
                    Console.WriteLine("You exceed number from 1 - 9");
                }
            } while (number.Count <=8);
             
             
         

            //Show 9 DIGITS
            Console.Write("Your SIN: ");
            foreach (int obj in number)
            {
                Console.Write(obj);
            }
            Console.WriteLine("");


            // add first set of alternates to themselves
            int pair1 = number[1] + number[1];
            int pair2 = number[3] + number[3];
            int pair3 = number[5] + number[5];
            int pair4 = number[7] + number[7];

            int[] digit1 = pair1.ToString().ToCharArray().Select(x => (int)Char.GetNumericValue(x)).ToArray();
            int[] digit2 = pair2.ToString().ToCharArray().Select(x => (int)Char.GetNumericValue(x)).ToArray();
            int[] digit3 = pair3.ToString().ToCharArray().Select(x => (int)Char.GetNumericValue(x)).ToArray();
            int[] digit4 = pair4.ToString().ToCharArray().Select(x => (int)Char.GetNumericValue(x)).ToArray();

            int[] storePair;
            storePair = digit1.Concat(digit2).Concat(digit3).Concat(digit4).ToArray();

            Console.WriteLine("");

            int totalOfDigit = storePair.Sum();

            int leftOverDigits = number[0] + number[2] + number[4] + number[6];

            int finalTotal = totalOfDigit + leftOverDigits;

            int temp = 1;
            int highestInteger = 10;
            while (temp * 10 <= finalTotal)
            {
                temp++;
            }
            highestInteger *= temp;

            if (highestInteger - finalTotal != number[8])
            {
                Console.WriteLine("This is not a valid SIN.");
            }
            else
            {
                Console.WriteLine("This is a valid SIN.");
            }
            Console.WriteLine("");
        }
    }
}