using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_With_OOP
{
    internal class User
    {
        private int ID { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }

        private static string AdminEmail { get; set; }

        private static string AdminPassword { get; set; }

        public static int cnt = 0;

        public void AddUser(List<User> users)
        {
            Console.WriteLine($"============================Add User================================");

            Console.Write("Enter Your Name: ");
            string Name = Console.ReadLine();
            while (int.TryParse(Name, out _))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Typing Error!!");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Enter Your Name: ");
                Name = Console.ReadLine();
            }

            Console.Write("Enter Your Age: ");
            string Age = Console.ReadLine();
            while (!int.TryParse(Age, out _))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Typing Error!!");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Enter Your Age: ");
                Age = Console.ReadLine();
            }

            Console.Write("Enter Your Email: ");
            string Email = Console.ReadLine();
            while (int.TryParse(Email, out _))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Typing Error!!");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Enter Your Email: ");
                Email = Console.ReadLine();
            }

            Console.Write("Enter Your Number: ");
            string Number = Console.ReadLine();
            while (!int.TryParse(Number, out _))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Typing Error!!");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Enter Your Number: ");
                Number = Console.ReadLine();
            }

            Console.Write("Enter Your Password: ");
            string Password = Console.ReadLine();

            User newUser = new User
            {
                ID = ++cnt,
                Name = Name,
                Age = Age,
                Email = Email,
                PhoneNumber = Number,
                Password = Password
            };

            users.Add(newUser);

            Console.WriteLine($"============================User Information you Enterd================================");
            Console.WriteLine($"ID: {newUser.ID}");
            Console.WriteLine($"Name: {newUser.Name}");
            Console.WriteLine($"Age: {newUser.Age}");
            Console.WriteLine($"Email: {newUser.Email}");
            Console.WriteLine($"Phone Number: {newUser.PhoneNumber}");
            Console.WriteLine($"Password: {newUser.Password}");

        }

        public void UpdateUser(List<User> users)
        {
            if (users.Count == 0)
            {
                Console.WriteLine("No Users In List!!");
                return;
            }
            bool flag = false;

            Console.WriteLine($"============================Update Data of User================================");

            Console.WriteLine("Enter UserEmail & UserPassword you want to Edit: \n");
            Console.Write("UserEmail: ");
            string UserEmail = Console.ReadLine();
            Console.Write("UserPassword: ");
            string UserPassword = Console.ReadLine();

            User FoundedUser = users.FirstOrDefault(x => x.Email == UserEmail);

            if (FoundedUser != null)
            {
                if (FoundedUser.Password == UserPassword)
                {
                    Console.WriteLine("\n-----------------------------------\n1-Edit Name: \n2-Age: \n3-Email: \n4-PhoneNumber: \n5-Password");
                    int choseToEdit = int.Parse(Console.ReadLine());
                    if (choseToEdit == 1)
                    {
                        Console.Write("Enter Edited Name: ");
                        string newName = Console.ReadLine();
                        while (int.TryParse(newName, out _))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Typing Error!!");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("Enter Your Name: ");
                            newName = Console.ReadLine();
                        }
                        FoundedUser.Name = newName;
                        flag = true;
                    }
                    else if (choseToEdit == 2)
                    {
                        Console.Write("Enter Edited Age: ");
                        string newAge = Console.ReadLine();
                        while (!int.TryParse(newAge, out _))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Typing Error!!");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("Enter Your Age: ");
                            newAge = Console.ReadLine();
                        }
                        FoundedUser.Age = newAge;
                        flag = true;

                    }
                    else if (choseToEdit == 3)
                    {
                        Console.Write("Enter Edited Email: ");
                        string newEmail = Console.ReadLine();
                        while (int.TryParse(newEmail, out _))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Typing Error!!");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("Enter Your Age: ");
                            newEmail = Console.ReadLine();
                        }
                        FoundedUser.Email = newEmail;
                        flag = true;

                    }
                    else if (choseToEdit == 4)
                    {
                        Console.Write("Enter Edited PhoneNumber: ");
                        string newPhone = Console.ReadLine();
                        while (!int.TryParse(newPhone, out _))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Typing Error!!");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("Enter Your PhoneNumber: ");
                            newPhone = Console.ReadLine();
                        }
                        FoundedUser.PhoneNumber = newPhone;
                        flag = true;

                    }
                    else if (choseToEdit == 5)
                    {
                        Console.Write("Enter Edited Password: ");
                        string newPassword = Console.ReadLine();
                        FoundedUser.Password = newPassword;
                        flag = true;
                    }

                    if (flag == true)
                    {
                        Console.WriteLine($"============================User Information you Enterd================================");
                        Console.WriteLine($"ID: {FoundedUser.ID}");
                        Console.WriteLine($"Name: {FoundedUser.Name}");
                        Console.WriteLine($"Age: {FoundedUser.Age}");
                        Console.WriteLine($"Email: {FoundedUser.Email}");
                        Console.WriteLine($"Phone Number: {FoundedUser.PhoneNumber}");
                        Console.WriteLine($"Password: {FoundedUser.Password}");
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Password Is Wrong!! Try Again From First");
                    Console.ResetColor();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No User Like This"); ;
                Console.ResetColor();
            }
        }

        public void DeleteUser(List<User> users)
        {
            Console.WriteLine($"============================Delete User================================");
            Console.WriteLine("Enter UserEmail & UserPassword you want to Delete: ");
            Console.Write("UserEmail: ");
            string UserEmail = Console.ReadLine();
            Console.Write("UserPassword: ");
            string UserPassword = Console.ReadLine();

            User FoundedUser = users.FirstOrDefault(x => x.Email == UserEmail);
            if (FoundedUser != null)
            {
                if (FoundedUser.Password == UserPassword)
                {
                    var name = FoundedUser.Name;
                    if (FoundedUser != null)
                    {
                        users.Remove(FoundedUser);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"- YOU DELETE USER : {name}.");
                        Console.ResetColor();

                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Not Found This User!!");
                        Console.ResetColor();
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Password Is Wrong!! Try Again From First");
                    Console.ResetColor();
                }
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No User Like This!!");
                Console.ResetColor();
            }


        }

        public void PrintUser(List<User> users)
        {

            if (users.Count == 0)
            {
                Console.WriteLine("No Users In List!!");
                return;
            }

            Console.WriteLine("Enter UserEmail & UserPassword You Want To Print Info: ");
            Console.Write("UserEmail: ");
            string UserEmail = Console.ReadLine();
            Console.Write("UserPassword: ");
            string UserPassword = Console.ReadLine();

            User FoundedUser = users.FirstOrDefault(x => x.Email == UserEmail);
            if (FoundedUser != null)
            {
                if (FoundedUser.Password == UserPassword)
                {
                    Console.WriteLine($"============================Print User Information================================");

                    Console.WriteLine($"User <{FoundedUser.Name}>");
                    Console.WriteLine($"ID: {FoundedUser.ID}");
                    Console.WriteLine($"Name: {FoundedUser.Name}");
                    Console.WriteLine($"Age: {FoundedUser.Age}");
                    Console.WriteLine($"Email: {FoundedUser.Email}");
                    Console.WriteLine($"Phone Number: {FoundedUser.PhoneNumber}");
                    Console.WriteLine($"Password: {FoundedUser.Password}");

                    if (cnt <= users.Count)
                    {
                        Console.WriteLine("----------------");
                    }

                }

                else
                {
                    Console.WriteLine("Password Is Wrong!! Try Again From First");
                }
            }

            else
            {
                Console.WriteLine("No User Like This!!");
            }


        }

        public void PrintAllUsers(List<User> users)
        {
            int cnts = 0;
            if (users.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("List Is Empty!!");
                Console.ResetColor();
                return;
            }

            User.AdminEmail = "Admin";
            User.AdminPassword = "Admin";

            Console.WriteLine("Enter AdminEmail & AdminPassword To Print All Users Info: ");
            Console.Write("AdminEmail: ");
            string AdminEmail = Console.ReadLine();
            Console.Write("AdminPassword: ");
            string AdminPassword = Console.ReadLine();

            if (User.AdminEmail == AdminEmail && User.AdminPassword == AdminPassword)
            {
                Console.WriteLine($"============================Print All Users Informations================================");

                foreach (User user in users)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"User <{++cnts}>");
                    Console.WriteLine($"ID: {user.ID}");
                    Console.WriteLine($"Name: {user.Name}");
                    Console.WriteLine($"Age: {user.Age}");
                    Console.WriteLine($"Email: {user.Email}");
                    Console.WriteLine($"Phone Number: {user.PhoneNumber}");
                    Console.WriteLine($"Password: {user.Password}");

                    if (cnts <= users.Count)
                    {
                        Console.WriteLine("----------------");
                    }
                }


            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Email Or Password Is Wrong!! Try Again From First");
                Console.ResetColor();
            }

        }



    }


}
