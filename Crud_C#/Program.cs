using CRUD_With_OOP;
using System;
using System.Collections.Generic;

namespace CRUD_With_OOP
{
    internal class Program
    {
        public static void Main(String[] args)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@" __    __   _______  __       __        ______   ______   ");
            Console.WriteLine(@"|  |  |  | |   ____||  |     |  |      /      | /  __  \  ");
            Console.WriteLine(@"|  |__|  | |  |__   |  |     |  |     |  ,----'|  |  |  | ");
            Console.WriteLine(@"|   __   | |   __|  |  |     |  |     |  |     |  |  |  | ");
            Console.WriteLine(@"|  |  |  | |  |____ |  `----.|  `----.|  `----.|  `--'  | ");
            Console.WriteLine(@"|__|  |__| |_______||_______||_______| \______| \______/  ");
            Console.WriteLine();
            Console.WriteLine("**************************************************************");
            Console.WriteLine("*                    * User Management *                     *");
            Console.WriteLine("*                      SYSTEM IS READY                       *");
            Console.WriteLine("**************************************************************");
            Console.ResetColor();

            List<User> users = new List<User>();
            User user = new User();

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n?? Please select an operation:\n");
                Console.WriteLine("  [1] <Add User>");
                Console.WriteLine("  [2] <Update User>");
                Console.WriteLine("  [3] <Delete User>");
                Console.WriteLine("  [4] <View User>");
                Console.WriteLine("  [5] <View All Users>");
                Console.WriteLine("  [0] <Exit>");
                Console.Write("\n Enter your choice: ");
                Console.ResetColor();

                string input = Console.ReadLine();
                Console.Clear();

                if (!int.TryParse(input, out int choice))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("?? Invalid input. Please enter a number.");
                    Console.ResetColor();
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Green;
                        user.AddUser(users);
                        Console.ResetColor();
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Green;
                        user.UpdateUser(users);
                        Console.ResetColor();
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Green;
                        user.DeleteUser(users);
                        Console.ResetColor();
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Green;
                        user.PrintUser(users);
                        Console.ResetColor();
                        break;
                    case 5:
                        Console.ForegroundColor = ConsoleColor.Green;
                        user.PrintAllUsers(users);
                        Console.ResetColor();
                        break;
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Exiting the system. Goodbye!");
                        Console.ResetColor();
                        return;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid choice.");
                        Console.ResetColor();
                        break;
                }

                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\nPress any key to continue...");
                Console.ResetColor();
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
