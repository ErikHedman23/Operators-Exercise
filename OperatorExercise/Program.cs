﻿using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            double operations = Add(1,2);
            
            ThoughtQuestion();
      
            
            Operators();

            double area = AreaOfCircle();

            
            
           

        }

        public static double Add(double a, double b)
        {
            double operations = a + b;
            Console.WriteLine(operations);
            return operations;
           
        }
        public static void Operators()
        {
            int a = 17;
            int b = 4;
            int remainder = a % b;
            int quotient = a / b;

            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            
            Console.WriteLine(quotient);
            Console.WriteLine(remainder);
            Console.WriteLine($"{a}/{b} = {quotient} with a remainder of {remainder}.");

          }

        public static double AreaOfCircle()
        {
            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());
            double area = Math.PI* Math.Pow(radius, 2); //can also be written as Math.PI* radius * radius;
            Console.WriteLine($"The area of your circle is {area}");
            return area;


        }
        public static void ThoughtQuestion()
        {
            // var is implicit type inferrence (more on this later)
            var i = 3;
            var j = 4;
            var k = ++i * j++;

            Console.WriteLine(k); // ouputs ?
            
        }

            
        }


    }

