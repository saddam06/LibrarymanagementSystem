using System;

namespace LibraryManagementSystem
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(" who you are: \n "+
                "Enter 1 for admin \n"+" Enter 2 for Student ");

            int choice1 = Convert.ToInt32(Console.ReadLine());

            Admin librarianObj = new Admin();
            Students studentObj = new Students();

            if (choice1 == 1)
            {
                librarianObj.adminClass();

            }
            else if (choice1 == 2)
            {
                studentObj.studentClass();

            }
        }
    }


}