﻿using System;

namespace MethodOverloadingExercise
{
    class Program
    {
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Add(params int[] numbers)
        {
            var sum = 0;

            foreach(var num in numbers)
            {
                sum += num;
            }

            return sum;
        }

        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        public static string Add(int num1, int num2, bool isTrue)
        {
            var sum = num1 + num2;

            if(isTrue && sum > 1 || sum < 1)
            {
                return $"{sum} dollars";
            }
            else if(isTrue)
            {
                return $"{sum} dollar";
            }
            else
            {
                return sum.ToString();
            }
        }

        static void Main(string[] args)
        {
            //var myBool = long.TryParse(Console.ReadLine(), out var result);

            //var myWeight = 198.6;

            //Print(myWeight);

            //Console.WriteLine();

            //Math.Abs(myWeight);

            //Console.WriteLine(Add(7, 8));

            //Console.WriteLine(Add(8.2m, 13.5m));

            
            //Console.WriteLine(Add(0, 1, true));
            //Console.WriteLine();

            //Console.WriteLine(Add(5, 7, true));
            //Console.WriteLine();

            //Console.WriteLine(Add(-6, 3, true));
            //Console.WriteLine();

            //Console.WriteLine(Add(5, 5, false));
            //Console.WriteLine();

            Console.WriteLine(Add(1, 1, 1, 1, 1, 1, 1));


        }




        //public static void SayHi(string name)
        //{
        //    Console.WriteLine($"Hello, {name}. How are you?");
        //}

        //public static void SayHi(string name, bool isHappy)
        //{
        //    if(isHappy)
        //    {
        //        Console.WriteLine($"Hello, {name}. I'm glad you're happy.");
    }
}
