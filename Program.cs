namespace CRUD_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("================================= WELCOME TO CRUD SYSTEM =========================================");
            List<user> list=new List<user>();
           managingUsers manageusers=new managingUsers(list);
            bool continueloop = true;
            while (continueloop)
            {
                Console.WriteLine("1 to add user");
                Console.WriteLine("2 to update user");
                Console.WriteLine("3 to delete user");
                Console.WriteLine("4 to read all user");
                Console.WriteLine();
                int r=int.Parse(Console.ReadLine());
                if(r==1)
                {
                    manageusers.Add();
                }
                else if(r==2)
                    manageusers.update();
                else if (r == 3)
                    manageusers.delete();
                else if (r == 4)
                    manageusers.print();
                Console.WriteLine("1 to continue\t 2 to break");
                int choose=int.Parse(Console.ReadLine());
                 if (choose == 2)
                    continueloop = false;
                 if(choose==1)
                Console.WriteLine("**********************************************");
            }
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("*********************thanks for using our program**********************");
            Console.ForegroundColor = ConsoleColor.White;

        }

    }
}
