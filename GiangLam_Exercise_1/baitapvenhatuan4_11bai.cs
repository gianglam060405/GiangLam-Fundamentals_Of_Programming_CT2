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
            baitap05();
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
            Console.WriteLine($"The coordinate point {x},{y} lies in {(x > 0 ? (y > 0 ? "First" : "Fourth") : (y > 0 ? "Second" : (x < 0 && y < 0 ? "Third" : "on an axis")))} Quadrant");
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
    }

}
