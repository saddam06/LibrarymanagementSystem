using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementSystem
{
    internal class Admin : Program
    {
        public void adminClass()
        {
            
            Console.WriteLine("What do you want to manage today?");
            Console.WriteLine("Enter 1 for Books \n" + "Enter 2 for Newspaper \n" + "Enter 3 to Quit ");

            Admin l = new Admin();

            int Choice = int.Parse(Console.ReadLine());
            

            Books booksObj = new Books();
            Newspaper newsobj = new Newspaper();

            if (Choice == 1)
            {
                booksObj.Bookmethod();
            }
            else if (Choice == 2)
            {
                newsobj.news();

            }



        }
    }
}