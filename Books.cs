using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementSystem
{
    internal class Books : Newspaper
    {
        public void Bookmethod()
        {
           Console.WriteLine(
                 "Enter 1 for To add books \n" + " Enter 2 to remove books \n " + " Enter 3 available books \n" +" Enter 4 for Menu");
            
           

            Addition addObj = new Addition();

            
            int choice1 = int.Parse(Console.ReadLine());

            if (choice1 == 1)
            {
                Console.WriteLine("Number of books you want to add");
                int Number = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < Number; i++)
                {
                    Console.WriteLine("Enter Book ID: ");
                    int id = Convert.ToInt32(Console.ReadLine());

                    



                    Console.WriteLine("Enter Book Name: ");
                    string name = Console.ReadLine();

                    Console.WriteLine("Enter author Name: ");
                    string authorinput = Console.ReadLine();

                    Console.WriteLine("Enter Book Price: ");
                    int price = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine();
                    Console.WriteLine();

                    addObj.ADD(new Book { ID = id, Name = name, AUTHORNAME = authorinput,PRICE=price });
                }
                Console.WriteLine("following books are in stack");

                foreach (Book x in addObj)
                {
                    Console.WriteLine($"BookID:{x.ID}  BookName:{x.Name} AuthorName:{x.AUTHORNAME} Price:{x.PRICE} ");
                }
                Console.WriteLine();

                Bookmethod();

            }
            else if (choice1 == 2)
            {
                Console.WriteLine("Enter Book ID to Remove: ");
                int i = Convert.ToInt32(Console.ReadLine());
                addObj.Rem(i);

                foreach (Book x in addObj)
                {
                    Console.WriteLine($"BookID:{x.ID}  BookName:{x.Name} AuthorName:{x.AUTHORNAME} Price:{x.PRICE} ");
                }
                Console.WriteLine();
                Bookmethod();
            }
            else if (choice1 == 3)
            {
                foreach (Book x in addObj)
                {
                    Console.WriteLine($"BookID:{x.ID}  BookName:{x.Name} AuthorName:{x.AUTHORNAME} Price:{x.PRICE} ");
                }
                Console.WriteLine();
                Bookmethod();
            }
            else
            {
                Console.WriteLine("Enter 1 for Books \n"+ " 2 for Newspaper ");
                int y = Convert.ToInt32(Console.ReadLine());
                if (y == 1)
                {
                    Bookmethod();
                }
                else if (y == 2)
                {
                    news();
                }
            }
        }

    }
}