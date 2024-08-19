
namespace GiangLam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter 1st number:");
            int number_01 = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter 2nd number:");
            int number_02 = Convert.ToInt32(Console.ReadLine());
            int sum = number_01 + number_02;
            Console.WriteLine("tong hai so la: " + sum);
            baitap02a();
            baitap02b();
            baitap03();
            baitap04();
            baitap05();
            baitap06();
            baitap08();
            baitap09();
            baitap10();

        }
        static void baitap02a()
        {
            int x = 5, y = 3;
            Console.WriteLine($"before swap a={x}, b={y}");
            int temp = x;
            y = x;
            y = temp;
            Console.WriteLine($"after swap a={x}, b={y}");
        }
        static void baitap02b()
        {
            Console.WriteLine("enter m:");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter n");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before swap: m = " + m + ", n = " + n);
            m = m + n;
            n = m - n;
            m = m - n;
            Console.WriteLine("After swap: m = " + m + ", n = " + n);
        }
        static void baitap03()
        {
            Console.WriteLine("enter first float number");
            decimal u = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("enter second float number");
            decimal y = Convert.ToDecimal(Console.ReadLine());
            decimal multiply = u * y;
            Console.WriteLine("After multiplying two numbers = " + multiply);
        }
        static void baitap04()
        {
            Console.WriteLine("enter feet number: ");
            decimal f = Convert.ToDecimal(Console.ReadLine());
            decimal toMeter = 0.3048M;
            decimal meter = toMeter * f;
            Console.WriteLine("meter number after converting: " + meter);
        }
        static void baitap05()
        {
            Console.Write("enter number C or F = ");
            decimal Number_C_or_F = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Type you want to converse C or F = ");
            string Type_C_or_F = Convert.ToString(Console.ReadLine());
            if (Type_C_or_F == "C")
            {
                Console.WriteLine("number C = " + (5 / 9 * (Number_C_or_F - 32)));
            }
            else if (Type_C_or_F == "F")
            {
                Console.WriteLine("number F = " + (9 / 5 * Number_C_or_F + 32));
            }
            else
            {
                Console.WriteLine("Not available");
            }
        }
        static void baitap06()
        {
            Console.WriteLine(" size of the type int: " + sizeof(int) + "bytes");
            Console.WriteLine("size of the type decimal: " + sizeof(decimal) + "bytes");
            Console.WriteLine("size of the type float: " + sizeof(float) + "bytes");
            Console.WriteLine("size of the type double: " + sizeof(double) + "bytes");
            Console.WriteLine("size of the type bool: " + sizeof(bool) + " bytes");
            Console.WriteLine("size of the type byte: " + sizeof(byte) + " bytes");
            Console.WriteLine("size of the type char: " + sizeof(char) + " bytes");
        }
        static void baitap08()
        {
            Console.WriteLine("enter radius number = ");
            decimal radius = Convert.ToDecimal(Console.ReadLine());
            decimal pi = 3.14M;
            decimal area = pi * radius * radius;
            Console.WriteLine("area of circle = " + area);
        }
        static void baitap09()
        {
            Console.WriteLine("enter side number = ");
            decimal side = Convert.ToDecimal(Console.ReadLine());
            decimal areaOfSquare = side * side;
            Console.WriteLine("area of square = " + areaOfSquare);
        }
        static void baitap10()
        {
            Console.WriteLine("enter number of days = ");
            int days = Convert.ToInt32(Console.ReadLine());
            int numberOfYears = days / 365;
            int remainingDays = days - (numberOfYears * 365);
            int numberOfWeeks = remainingDays / 7;
            int numberOfDays = days - (numberOfYears * 365 + numberOfWeeks * 7);
            Console.WriteLine("number of years = " + numberOfYears + ", number of weeks = " + numberOfWeeks
                + ", number of days = " + numberOfDays);
        }
    }
}





