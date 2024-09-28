using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.ComponentModel.Design;
using System.Xml.Linq;
namespace GiangLam
{
    internal class Programm
    {
        static void Mainr(string[] args)
        {
            Console.WriteLine("Enter the number of rows.");
            int rows = int.Parse(Console.ReadLine());
            int[][] d = new int[rows][];
            while (true)
            {
                int sel = menu();
                switch (sel)
                {
                    case 0: Console.WriteLine("Bye"); return;
                    case 1:
                        RandomNumber(d, rows);
                        PrintTheBiggestNumber(d, rows); break;
                    case 2: SortRows(d); break;
                    case 3: PrintPrimeNumber(d); break;
                    case 4:
                        Console.Write("Enter a number to search it.");
                        int n = int.Parse(Console.ReadLine());
                        SearchAndPrint(d, n); break;


                }
            }
        }
        static int menu()
        {
            Console.WriteLine("\t\n...\n");
            Console.WriteLine("Choose 1-4: ");
            Console.WriteLine("1.Print the biggest number of each row and the largest number of the whole array");
            Console.WriteLine("2.Sort values ascending of each row.");
            Console.WriteLine("3.Print items of the array that are prime.");
            Console.WriteLine("4.Search and print all positions of a number.");
            Console.WriteLine();
            int sel = 0;
            while (true)
            {
                bool c = int.TryParse(Console.ReadLine(), out sel);
                if (c && sel >= 0 && sel <= 4)
                    break;
                else Console.WriteLine("Please enter a valid number");
            }
            return sel;
        }
        static void RandomNumber(int[][] d, int rows)
        {
            Random rnd = new Random();
            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine($"Enter the number of the columns of the row {i}th:");
                int column = int.Parse(Console.ReadLine());
                d[i] = new int[column];
                for (int j = 0; j < d[i].Length; j++)
                {
                    d[i][j] = rnd.Next(10, 50);
                }
            }
            Printdata(d);
        }
        static void InputFromUser(int[][] d, int rows)
        {
            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine($"Enter the columns for you {i}: ");
                int col = int.Parse(Console.ReadLine());
                d[i] = new int[col];
                for (int j = 0; j < d[i].Length; j++)
                {
                    d[i][j] = int.Parse(Console.ReadLine());
                }
            }
        }
        static void Printdata(int[][] d)
        {
            for (int i = 0; i < d.Length; i++)
            {
                for (int j = 0; j < d[i].Length; j++)
                {
                    Console.Write(d[i][j] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void PrintTheBiggestNumber(int[][] d, int rows)
        {
            int maxvalue = 0;
            bool result = true;
            for (int i = 0; i < d.Length; i++)
            {
                int max = d[i][0];
                for (int j = 0; j < d[i].Length; j++)
                {
                    if (d[i][j] > max)
                    {
                        max = d[i][j];

                    }
                }
                Console.WriteLine($"The biggest number of the row {i} is:" + max);
            }
            for (int i = 0; i < d.Length; i++)
            {
                for (int j = 0; j < d[i].Length; j++)
                {
                    if (d[i][j] > maxvalue)
                    {
                        maxvalue = d[i][j];
                        result = true;
                    }
                }
            }
            if (result == true)
            {
                Console.WriteLine("The biggest number of the array is:" + maxvalue);
            }
            else
            {
                Console.WriteLine("Not found");
            }

        }
        static void SortArray(int[] d)
        {
            for (int i = 0; i < d.Length; i++)
            {
                for (int j = 0; j < d.Length - 1; j++)
                {
                    if (d[j] > d[j + 1])
                    {
                        int temp = d[j];
                        d[j] = d[j + 1];
                        d[j + 1] = temp;
                    }
                }
            }
        }
        static void SortRows(int[][] d)
        {
            for (int i = 0; i < d.Length; i++)
            {
                for (int j = 0; j < d[i].Length; j++)
                {
                    SortArray(d[i]);
                }
            }
            Printdata(d);
        }
        static bool CheckPrime(int d)
        {
            if (d < 2)
                return false;
            for (int i = 2; i <= d / 2; i++)
            {
                if (d % i == 0)
                    return false;
            }
            return true;
        }
        static void PrintPrimeNumber(int[][] d)
        {
            int n = 0;
            for (int i = 0; i < d.Length; i++)
            {
                for (int j = 0; j < d[i].Length; j++)
                {
                    if (CheckPrime(d[i][j]))
                        Console.WriteLine($"{d[i][j]} appears at row[{j}]");
                    n++;
                }
            }
            if (n == 0)
                Console.WriteLine("Not found prime number");

        }
        static void SearchAndPrint(int[][] d, int n)
        {
            bool found = false;
            for (int i = 0; i < d.Length; i++)
            {
                for (int j = 0; j < d[i].Length; j++)
                {
                    if (d[i][j] == n)
                    {
                        Console.WriteLine($"The position of {n} is at row[{i}], column [{j}].");
                        found = true;
                    }

                }
            }
            if (!found)
            {
                Console.WriteLine("Not found in the array");
            }

        }

    }

}
