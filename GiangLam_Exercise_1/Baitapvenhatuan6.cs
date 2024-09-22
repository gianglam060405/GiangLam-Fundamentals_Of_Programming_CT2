using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiangLam_Exercise_1
{
    internal class Baitapvenhatuan6
    {
        public static void Main(string[] args)
        {
            //first exercise
            int[] arr = { 1, 2, 4, 4, 5 };
            double average = CalculateTheAverageValue(arr);
            Console.WriteLine($"The average value of the array is: {average} ");
            Console.WriteLine();
            //second exercise
            int value = int.Parse(Console.ReadLine());
            bool specific = TestIfContainSpecificValue(arr, value);
            Console.WriteLine(specific ? $"The array contain {value}" : $"The array doesn't contain {value}");
            Console.WriteLine();
            //third exercise
            int element = int.Parse(Console.ReadLine());
            int index = FindTheIndexOfElement(arr, element);
            if (index != -1)
            {
                Console.WriteLine($"The index of the value {element} is {index}");
            }
            else
            {
                Console.WriteLine($"Value {element} is not found in the array");
            }
            Console.WriteLine();
            //forth exercise
            int removeElement = int.Parse(Console.ReadLine());
            bool respeel = RemoveSpecificElementFromAnArray(arr, removeElement);
            Array.Resize(ref arr, arr.Length - 1);
            PrintRemoveArray(arr);
            Console.WriteLine();
            //fifth exercise
            PrintMaxMinnumber(arr);
            Console.WriteLine();
            //sixth exercise
            ReverseArray(arr);
            PrintReverseArray(arr);
            Console.WriteLine();
            //seventh exercise 
            FindDuplicateValue(arr);
            //eight exercise
            //nt b = arr[i];
            //RemoveDuplicateElement(arr, b);
            //ninth exercise
            BubbleSort(arr);
            //tenth exercise
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter sentence:");
                string sentence = Console.ReadLine();
                if (sentence == null)
                {
                    Console.WriteLine("Please enter in the correct form of a sentence");
                    Console.WriteLine("Enter word");
                    string word = Console.ReadLine();
                    bool result = CheckWordExistInSentence(sentence, word);
                    Console.WriteLine(result ? "Word appears" : "Word doesn't appear");
                }
            }


        }
        //first exercise
        static double CalculateTheAverageValue(int[] arr)
        {
            double sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                //arr[i] = rnd.Next(1,50);
                //Console.WriteLine($"Computer number is: {arr[i]} ");
                sum += arr[i];

            }
            double average = sum / arr.Length;
            return average;
        }
        //second exercise
        static bool TestIfContainSpecificValue(int[] arr, int value)
        {
            foreach (int i in arr)
            {

                //Console.WriteLine($"Computer number is: {i}");
                if (i == value)
                    return true;
            }
            return false;
        }
        //third exercise
        static int FindTheIndexOfElement(int[] arr, int element)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                //Console.WriteLine($"Computer number is: {arr[i]}");
                if (arr[i] == element)
                    return i;
            }
            return -1;
        }
        //forth exercise
        static bool RemoveSpecificElementFromAnArray(int[] arr, int speElement)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == speElement)
                {
                    for (int j = i; j < arr.Length - 1; j++)
                    {
                        arr[j] = arr[j + 1];
                    }
                    return true;

                }
            }
            return false;
        }
        static void PrintRemoveArray(int[] arr)
        {
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        //fifth exercise
        static void PrintMaxMinnumber(int[] arr)
        {
            int max = arr[0], min = arr[0];
            foreach (int val in arr)
            {
                if (val > max) max = val;
                if (val < min) min = val;

            }
            Console.WriteLine($"Min of the array is: {min}; max of the array is: {max} ");
        }
        //sixth exercise
        static void ReverseArray(int[] arr)
        {
            int start = 0;
            int end = arr.Length - 1;
            {
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
        }
        static void PrintReverseArray(int[] arr)
        {
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        //seventh exercise
        static void FindDuplicateValue(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        Console.WriteLine($"The duplicate value is: {arr[i]}");
                        count++;
                    }
                    else
                    {
                        Console.WriteLine("There is no duplicate value in the array");
                        break;
                    }

                }

            }
            return;
        }
        //eighth exercise

        static void RemoveDuplicateElement(int[] arr, int b)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        Console.WriteLine($"The duplicate value is: {arr[i]}");
                        count++;
                        b = arr[i];
                    }
                    else
                    {
                        Console.WriteLine("There is no duplicate value in the array");
                    }
                    break;
                }
            }

            RemoveSpecificElementFromAnArray(arr, b);
            PrintRemoveArray(arr);
            Console.WriteLine();
        }
        //ninth exercise
        static void BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        //tenth exercise
        static bool CheckWordExistInSentence(string sentence, string word)
        {
            char[] s = sentence.ToCharArray();
            char[] w = word.ToCharArray();

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < w.Length; j++)
                {
                    if (s[i] == w[j])
                    {
                        return true;
                    }

                }
            }
            return false;
        }
    }
}
