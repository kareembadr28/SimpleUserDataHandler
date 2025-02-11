using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_project
{
    internal class managingUsers
    {
        List<user> Users;
        public managingUsers(List<user> Users)
        {
            this.Users = Users;
        
        }

        public void Add()
        {
            Console.WriteLine();
            Console.WriteLine("======================================= ADD USER SERVICE =========================================");
            ;
            Console.Write("enter name : ");
            string name = Console.ReadLine();
            
            Console.WriteLine("==============================================");
            Console.Write("enter phonenumber : ");
            string phonenumber = Console.ReadLine();
            Console.WriteLine("==============================================");

            Console.Write("enter email : ");
            string email = Console.ReadLine();
            Console.WriteLine("==============================================");
            user newuser=new user(name,phonenumber, email);
            Users.Add(newuser);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("new user have been added");
            Console.WriteLine("====================");
            Console.WriteLine("name : " + newuser.Name);
            Console.WriteLine("phonenumber : " + newuser.PhoneNumber);
            Console.WriteLine("Email : " + newuser.Email);
            Console.WriteLine("**********************************************************************************************************************");
            Console.ForegroundColor = ConsoleColor.White;

        }
        public void update()
        {
            Console.WriteLine();
            Console.WriteLine("====================================== UPDATE USER SERVICE =======================================");
            Console.Write("enter the email: ");
            string email = Console.ReadLine();
            user foundeduser = Users.helpfind(x => x.Email == email);//can use first or default but i prefer extension method to practive
            if (foundeduser != null)
            {
                Console.WriteLine("enter 1 to update name\t 2 for phone\t 3 for email: ");
                Console.WriteLine();
                int choise = int.Parse(Console.ReadLine());
                if (choise == 1)
                {
                    Console.Write("enter name : ");
                    string newname = Console.ReadLine();
                    foundeduser.Name = newname;
                }
                else if (choise == 2)
                {
                    Console.Write("enter PhoneNumber : ");
                    string newphone = Console.ReadLine();
                    foundeduser.PhoneNumber = newphone;
                }
                else if (choise == 3)
                {
                    Console.Write("enter Email : ");
                    string newemail = Console.ReadLine();
                    foundeduser.Email = newemail;
                }

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("there no user!!!!");
                Console.ForegroundColor = ConsoleColor.White;

            }
        }
        public void print()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("====================================== PRINT ALL USER SERVICE =====================================");
            int count = 0;
            foreach (var item in Users)
            {
                Console.WriteLine("user number :" + ++count);
                Console.WriteLine("name : " + item.Name);
                Console.WriteLine("PhoneNumber: " + item.PhoneNumber);
                Console.WriteLine("Email: " + item.Email);
                Console.WriteLine("==============================================");
            }
            Console.ForegroundColor = ConsoleColor.White;

        }
        public void delete()
        {
            Console.WriteLine();
            Console.WriteLine("======================================= DELETE USER SERVICE ======================================");
            Console.Write("enter the email: ");
            string email = Console.ReadLine();
            user foundeduser = Users.FirstOrDefault(x => x.Email == email);
            if (foundeduser != null)
            {
                Console.WriteLine($"user with name: {foundeduser.Name} have been deleted");
                Users.Remove(foundeduser);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("there no user!!!!");
                Console.ForegroundColor = ConsoleColor.White;

            }
        }

    }
}
