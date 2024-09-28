using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiangLam_Exercise_1
{
    internal class Baitaparray_02
    {
        static void Main(string[] args)
        {
            //18
            int[,] matrix = new int[3, 3];
            PrintTheMatrix3x3(matrix);
            Console.WriteLine();
            //19
            int[,] firstmatrix = new int[2, 2];
            int[,] secondmatrix = new int[2, 2];
            int[,] addingmatrix = new int[2, 2];
            Console.WriteLine("Input elements in the first matrix : ");
            Matrix(firstmatrix, 2);
            Console.WriteLine("Input elements in the second matrix : ");
            Matrix(secondmatrix, 2);
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    addingmatrix[i, j] = firstmatrix[i, j] + secondmatrix[i, j];
                }
            }
            Console.WriteLine("The adding matrices are: ");
            Console.WriteLine("The First matrix is: ");
            Printmatrix(firstmatrix, 2);
            Console.WriteLine("The Second matrix is : ");
            Printmatrix(secondmatrix, 2);
            Console.WriteLine("The Addition of two matrix is : ");
            Printmatrix(addingmatrix, 2);
            //20
            int[,] firstmatrix2 = new int[2, 2];
            int[,] secondmatrix2 = new int[2, 2];
            int[,] addingmatrix2 = new int[2, 2];
            Console.WriteLine("Input elements in the first matrix :");
            SubtractionOfTwoMatrixes(firstmatrix2, 2);
            Console.WriteLine("Input elements in the second matrix :");
            SubtractionOfTwoMatrixes(secondmatrix2, 2);
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    addingmatrix2[i, j] = firstmatrix2[i, j] - secondmatrix2[i, j];
                }
            }
            Console.WriteLine("The First matrix is :");
            PrintMatrixSecond(firstmatrix2, 2);
            Console.WriteLine("The Second matrix is :");
            PrintMatrixSecond(secondmatrix2, 2);
            Console.WriteLine("The Subtraction of two matrix is :");
            PrintMatrixSecond(addingmatrix2, 2);
            //21
            Random rnd41 = new Random();
            int[] matrix41 = new int[10];
            for (int i = 0; i < 10; i++)
            {
                matrix41[i] = rnd41.Next(1, 21);
            }
            Console.WriteLine("Enter a number to find the equal numbers");
            int value41 = int.Parse(Console.ReadLine());
            FindEqualProduct(matrix41, value41);
            //39
            Console.WriteLine("Enter the number you want to type:");
            int n = int.Parse(Console.ReadLine());
            int[] primeNum = new int[n];
            for (int i = 0; i < n; i++)
            {
                primeNum[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Sum of prime numbers in an array is: " + SumOfPrime(primeNum));

            //38
            Console.WriteLine("Enter number for the number of numbers you will type");
            int a = int.Parse(Console.ReadLine());
            int[] arr = new int[a];
            for (int i = 0; i < a; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter the digit you want to find");
            int digit = int.Parse(Console.ReadLine());
            CheckDigit(arr, a, digit);
            //36
            int[] arr36 = { -3, -2, -1, 1, 2, 3, 4, 5 };
            CheckWhetherConsecutive(arr36);
            //37
            int[] arr37 = { 7, 5, 9, 10, 67 };
            CalculateTheSmallestGap(arr37);

            //22

        }
        //18
        static void PrintTheMatrix3x3(int[,] matrix)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"element - [{i}],[{j}] : ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("The matrix is: ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        //19
        static void Matrix(int[,] matrix, int size)
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine($"element - [{i}], [{j}] : ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        static void Printmatrix(int[,] matrix, int size)
        {

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
        //20
        static void SubtractionOfTwoMatrixes(int[,] matrixsecond, int size)
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    matrixsecond[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        static void PrintMatrixSecond(int[,] matrixsecond, int size)
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(matrixsecond[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        //41
        static void FindEqualProduct(int[] matrix41, int value41)
        {


            for (int i = 0; i < matrix41.Length; i++)
            {
                for (int j = i + 1; j < matrix41.Length; j++)
                {
                    if (matrix41[i] * matrix41[j] == value41)
                    {
                        Console.WriteLine($"Pair found: {matrix41[i]},{matrix41[j]}");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Can't find two numbers");
                    }
                    break;
                }
            }
        }
        static void PrintResult41(int[] result41, int value41)
        {
            if (result41.Length == 0)
            {
                Console.WriteLine("Can't find the product");
            }
            else
            {
                Console.WriteLine($"Found numbers: {result41[0]}, {result41[1]} with product {value41}");
            }
        }
        //39
        static int SumOfPrime(int[] primeNum)
        {
            int sum = 0;
            foreach (int number in primeNum)
            {
                if (IsPrime(number))
                {
                    sum += number;
                }

            }
            return sum;
        }
        static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;
            for (int i = 3; i <= Math.Sqrt(number); i += 2)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
        //38
        static void CheckDigit(int[] arr, int a, int digit)
        {
            bool found = false;
            foreach (int number in arr)
            {
                if (digit == number)
                {
                    found = true;
                    break;
                }
            }
            if (found == true)
            {
                Console.WriteLine("Present");
            }
            else
            {
                Console.WriteLine("Not present");
            }
        }
        //37
        static void CheckWhetherConsecutive(int[] arr36)
        {
            bool found = true;
            Array.Sort(arr36);
            for (int i = 1; i < arr36.Length; i++)
            {
                if (arr36[i] - arr36[i - 1] != 1)
                {
                    found = false;
                    break;
                }
            }
            if (found == false)
            {
                Console.WriteLine("Not consecutive");
            }
            else
            {
                Console.WriteLine(" Consecutive");
            }
            Console.WriteLine();
        }
        static int CalculateTheSmallestGap(int[] arr37)
        {
            Array.Sort(arr37);
            int smallestGap = int.MaxValue;
            for (int i = 1; i < arr37.Length; i++)
            {
                int gap = arr37[i] - arr37[i - 1];
                if (gap < smallestGap)
                {
                    smallestGap = gap;
                }

            }
            Console.WriteLine("The smallest gap is:" + smallestGap);
            return smallestGap;
        }
    }
}
