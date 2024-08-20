using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Gianglam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            baitap01();
            baitap02();
            baitap03();
            baitap04();
            baitap05();
        }
        static void baitap01()
        {
            Console.WriteLine("enter first number: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter second number: ");
            double b = Convert.ToDouble(Console.ReadLine());
            double sum = a + b;
            double minus = a - b;
            double mutiply = a * b;
            double division = a / b;
            Console.WriteLine("number after sum: " + sum + ", minus: " + minus + ", multiply: " + mutiply + ", division: " + division);
        }
        static void baitap02()
        {

            for (int y = -5; y <= 5; y++)
            {
                int x = y * y + y * 2 + 1;
                Console.WriteLine(" print value of the function of value y= " + y + " is: " + x);
            }


        }
        static void baitap03()
        {
            Console.WriteLine("enter hours number: ");
            double hours = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter minutes number: ");
            double minutes = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter seconds number: ");
            double seconds = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter distance number in kilometers: ");
            double distance = Convert.ToDouble(Console.ReadLine());
            double totalhours = hours + (minutes / 60) + ((seconds / 60) / 60);
            double speed_km = distance / totalhours;
            double speed_mile = speed_km * 0.621371;
            Console.WriteLine("speed in km/h: " + speed_km);
            Console.WriteLine("speed in mile/h: " + speed_mile);
        }
        static void baitap04()
        {
            Console.WriteLine("enter radius number: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double pi = Math.PI;
            double surface = 4 * Math.Pow(radius, 2) * pi;
            double volume = 4 / 3 * Math.Pow(radius, 3) * pi;
            Console.WriteLine("surface: " + surface + " and volume of the sphere: " + volume);
        }
        static void baitap05()
        {
            Console.WriteLine("enter a character: ");
            char character = char.Parse(Console.ReadLine());
            if (character == 'a' || character == 'e' || character == 'i' || character == 'o' || character == 'u' ||
                character == 'A' || character == 'E' || character == 'I' || character == 'O' || character == 'U')
            {
                Console.WriteLine("the character is a vowel.");
            }
            else if (char.IsDigit(character))
            {
                Console.WriteLine("the character is a digit.");
            }
            else
            {
                Console.WriteLine("the character is a symbol.");
            }
        }
    }
}

