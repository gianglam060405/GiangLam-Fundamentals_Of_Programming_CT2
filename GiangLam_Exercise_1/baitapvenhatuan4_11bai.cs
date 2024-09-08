using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiangLam_Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            baitap01();
            baitap02();
            baitap03();
            baitap04();
            baitap05();
            baitap06();
            baitap08();
            baitap09();
            baitap10();
        }
        static void baitap01()
        {
            Console.WriteLine("Enter a number to check even or odd: ");
            int n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine("The given number is even.");

            }
            else
            {
                Console.WriteLine("The given number is odd. ");
            }
        }
        static void baitap02()
        {
            Console.WriteLine("Enter number a, b, c");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Max number among three number is: " + Math.Max(Math.Max(a, b), c));
        }
        static void baitap03()
        {
            Console.WriteLine("Enter x coordinate: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter y coordinate: ");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine($"The coordinate point {x},{y} lies in {(x > 0 ? (y > 0 ? "First" : "Fourth") :
                (y > 0 ? "Second" : (x < 0 && y < 0 ? "Third" : "Origin")))} Quadrant");
        }
        static void baitap04()
        {
            Console.WriteLine("Enter number for three sides of the triangle: ");
            double a = int.Parse(Console.ReadLine());
            double b = int.Parse(Console.ReadLine());
            double c = int.Parse(Console.ReadLine());
            if (a + b > c && a + c > b && b + c > a && a > 0 && b > 0 && c > 0)
            {
                Console.WriteLine($"The triangle is: {((a == b && b == c) ? "Equilateral" : (a == b || b == c || a == c) ? "Isosceles" : "Scalene")} ");
            }
            else
            {
                Console.WriteLine("This is not a triangle");
            }
        }
        static void baitap05()
        {
            Console.WriteLine("Enter 10 number: ");
            int[] args = new int[10];
            int answer = 0;
            int average = 0;
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                args[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 10; i++)
            {
                sum = answer += args[i];
                average = sum / 10;
            }
            Console.WriteLine("Average of 10 numbers is: " + average + ". Sum of 10 number is: " + answer);
        }
        static void baitap06()
        {
            Console.WriteLine("Enter a number: ");
            int m = int.Parse(Console.ReadLine());
            int answer = 0;
            Console.WriteLine("The multiplication table of a given integer is: ");
            for (int i = 1; i <= 10; i++)
            {
                answer = m * i;
                Console.WriteLine($"{m} x {i} = {answer}");
            }
        }
        static void baitap07()
        {
            Console.WriteLine("Enter number to display a pattern triangles");
            int number = 4;
            int r_1 = 1;
            int r_2 = 1;
            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(r_1 + " ");
                    r_1++;
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 1; i <= number; i++)
            {
                for (int j = i; j <= number + 1; j++)
                {
                    Console.Write(" ");
                }
                for (int g = 1; g <= i; g++)
                {
                    Console.Write(r_2 + " ");
                    r_2++;
                }
                Console.WriteLine();
            }
        }
        static void baitap08()
        {
            Console.WriteLine("Enter n terms of harmonic series: ");
            double har_num = double.Parse(Console.ReadLine());
            double sum_har_num = 1;
            Console.Write("1");
            for (int i = 2; i <= har_num; i++)
            {
                Console.Write(" + ");
                Console.Write($" 1/{i} ");
                sum_har_num += 1.0 / i;
            }
            Console.WriteLine();
            Console.WriteLine($"Sum of n terms of harmonic series: {sum_har_num} ");
        }
        static void baitap09()
        {
            Console.WriteLine("Enter a given number: ");
            int g = int.Parse(Console.ReadLine());
            int answer = 0;
            for (int i = 1; i < g; i++)
            {
                if (g % i == 0)
                {
                    answer += i;
                }
            }
            if (answer == g)
            {
                Console.WriteLine("The given number is perfect.");
            }
            else
            {
                Console.WriteLine("The given number is not perfect.");
            }
        }
        static void baitap10()
        {
            Console.WriteLine("Enter a number to determine whether it is prime or not: ");
            int p = int.Parse(Console.ReadLine());
            int count = 0;
            if (p < 2)
            {
                Console.WriteLine("The number is not prime.");
            }
            for (int i = 2; i < p; i++)
            {
                if (p % i == 0)
                {
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("The number is prime.");

            }
            else
            {
                Console.WriteLine("The number is not prime.");
            }
            ///

        }

    }
}
