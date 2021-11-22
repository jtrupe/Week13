/// Week 13 Lab 1
///
/// @author: Julian Trupe
/// Date:  November 19, 2021
///
/// Problem Statement: Create a test program that implements optional parameters, named parameters, and variable parameters
//
/// Overall Plan:
/// 1) Write speak statement with optional text parameter
/// 2) Write printFirst function
/// 3) Write multiAdder function which takes variable parameters and adds them
/// 4) Test each function in the main method, use named parameters for printFirst
/// 

using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            speak();
            speak("Hello!");
            printFirst(second: "nothing", first: "FIRST!");
            Console.WriteLine(multiAdder(1, 2, 3, 4, 5));
        }

        public static void speak(string text= "default statement")
        {
            Console.WriteLine(text);
        }

        public static void printFirst(string first, string second)
        {
            Console.WriteLine(first);
        }

        public static int multiAdder(params int[] nums)
        {
            int sum = 0;
            foreach(int j in nums)
            {
                sum += j;
            }
            return sum;
        }
    }
}
