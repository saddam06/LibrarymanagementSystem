using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementSystem
{
    internal class Newspaper : Admin
    {


        public void news()
        {
            Console.WriteLine();
            Console.WriteLine("Enter 1 available newspaper");
            Console.WriteLine("Enter 2 for  Menu");
            Console.WriteLine();

            int input = Convert.ToInt32(Console.ReadLine());

            Newspaper2 value = new Newspaper2();

            if (input == 1)
            {
                foreach (newsPaper i in value)
                {
                    Console.WriteLine($"Name- {i.Name}");
                }
                Console.WriteLine();
                Console.ReadLine();
            }
            else if (input == 2)
            {
                adminClass();

            }

        }
    }
}