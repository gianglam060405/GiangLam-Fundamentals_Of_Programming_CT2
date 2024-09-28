using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiangLam_Exercise_1
{
    internal class Baitaparray_01
    {
        static void Main(string[] args)
        {
            string[][][] groups = new string[3][][];
            InitializeGroups(groups);

            while (true)
            {
                Console.WriteLine("\n--- X Company Member Management ---");
                Console.WriteLine("1. Print all members");
                Console.WriteLine("2. Print member information by ID");
                Console.WriteLine("3. Print member with highest completed tasks");
                Console.WriteLine("4. Exit");
                Console.Write("Select an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        PrintAllMembers(groups);
                        break;
                    case "2":
                        PrintMemberById(groups);
                        break;
                    case "3":
                        PrintHighestCompletedTasksMember(groups);
                        break;
                    case "4":
                        return; 
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            
            static void InitializeGroups(string[][][] groups)
            {
                groups[0] = new string[5][];
                groups[0][0] = new string[] { "1", "Alice Smith", "10" };
                groups[0][1] = new string[] { "2", "Bob Johnson", "5" };
                groups[0][2] = new string[] { "3", "Carol Williams", "12" };
                groups[0][3] = new string[] { "4", "David Brown", "7" };
                groups[0][4] = new string[] { "5", "Eva White", "6" };

                groups[1] = new string[3][];
                groups[1][0] = new string[] { "6", "Frank Miller", "4" };
                groups[1][1] = new string[] { "7", "Grace Davis", "8" };
                groups[1][2] = new string[] { "8", "Henry Garcia", "9" };

                groups[2] = new string[6][];
                groups[2][0] = new string[] { "9", "Ivy Rodriguez", "11" };
                groups[2][1] = new string[] { "10", "Jack Hernandez", "3" };
                groups[2][2] = new string[] { "11", "Kathy Martinez", "2" };
                groups[2][3] = new string[] { "12", "Leo Jackson", "0" };
                groups[2][4] = new string[] { "13", "Mia Lee", "15" };
                groups[2][5] = new string[] { "14", "Nora Perez", "1" };
            }

            
            static void PrintAllMembers(string[][][] groups)
            {
                for (int i = 0; i < groups.Length; i++)
                {
                    Console.WriteLine($"\nGroup {i + 1} Members:");
                    for (int j = 0; j < groups[i].Length; j++)
                    {
                        Console.WriteLine($"ID: {groups[i][j][0]}, Name: {groups[i][j][1]}, Completed Tasks: {groups[i][j][2]}");
                    }
                }
            }

            
            static void PrintMemberById(string[][][] groups)
            {
                Console.Write("Enter Member ID: ");
                string id = Console.ReadLine();

                for (int i = 0; i < groups.Length; i++)
                {
                    for (int j = 0; j < groups[i].Length; j++)
                    {
                        if (groups[i][j][0] == id)
                        {
                            Console.WriteLine($"ID: {groups[i][j][0]}, Name: {groups[i][j][1]}, Completed Tasks: {groups[i][j][2]}");
                            return;
                        }
                    }
                }

                Console.WriteLine("Member not found.");
            }

           
            static void PrintHighestCompletedTasksMember(string[][][] groups)
            {
                string[] highestMember = null;
                int highestTasks = -1;

                for (int i = 0; i < groups.Length; i++)
                {
                    for (int j = 0; j < groups[i].Length; j++)
                    {
                        int completedTasks = int.Parse(groups[i][j][2]);
                        if (completedTasks > highestTasks)
                        {
                            highestTasks = completedTasks;
                            highestMember = groups[i][j];
                        }
                    }
                }

                if (highestMember != null)
                {
                    Console.WriteLine($"Member with highest tasks: ID: {highestMember[0]}, Name: {highestMember[1]}, Completed Tasks: {highestMember[2]}");
                }
                else
                {
                    Console.WriteLine("No members found.");
                }
            }

        }
    }

}

    
