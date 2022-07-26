using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementSystem
{
    internal class Students
    {
        public void studentClass()

        {

            Console.WriteLine();
           
            Console.WriteLine("Enter 1 to BorrowBook \n"+ "Enter 2 to ReturnBook \n  "+ "Enter 3 to View Available Books \n" + "Enter 4 to search Book by ID");
            Console.WriteLine();
            int choice1 = Convert.ToInt32(Console.ReadLine());

            Addition AddObj = new Addition();

           

            if (choice1 == 1)
            {
                BorrowBook();
                studentClass();
            }
            else if (choice1 == 2)
            {
                ReturnOperation();
                studentClass();
            }
            else if (choice1 == 3)
            {
                foreach (Book x in AddObj)
                {
                    Console.WriteLine($"BookID:{x.ID}  BookName:{x.Name} AuthorName:{x.AUTHORNAME} Price:{x.PRICE} ");
                }
                studentClass();

            }
            else if (choice1 == 4)
            {
                foreach (Book x in AddObj)

                {
                    Console.WriteLine("Enter ID");
                    int input=Convert.ToInt32(Console.ReadLine());
                    if (x.ID == input)
                    {
                        Console.WriteLine($"Value found with the name { x.Name}");
                    }
                }
                studentClass();
            }



        }


        public static void ReturnBook()
        {
            Addition Addobj = new Addition();
            Console.Write("Enter Book Code To Return");
            string returning = Console.ReadLine();

            int r = int.Parse(returning);
            Console.WriteLine();
            foreach (Book i in Addobj)
            {
                if (i.ID.Equals(returning))
                {
                    if (i.IsBorrowed == true)
                    {
                        i.IsBorrowed = false;

                        Console.WriteLine("Book returned");
                        Console.WriteLine();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("this book is not borrowed");
                        Console.WriteLine();

                    }
                }

            }
        }
       
        public static void BorrowBook()
        {
            Addition Addobj = new Addition();
            Console.Write("Enter Book ID ");
            int borrow = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            
            foreach (Book i in Addobj)
            {
                if (i.ID.Equals(borrow))
                {
                    if (i.IsBorrowed == true)
                    {
                        Console.WriteLine("Already Issued");

                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine(i.ID + ":" + i.Name);
                        Console.WriteLine("Issued ");
                        DateTime now = DateTime.Now;
                        Console.WriteLine($" At {now}");
                        Console.ReadLine();


                        i.IsBorrowed = true;

                        Console.WriteLine();

                    }
                }

            }

        }
        public void ReturnOperation()
        {
            Console.WriteLine("Press 1 to Return book");
            Console.WriteLine("Press 2 to Exit");
            Console.WriteLine();

            int value = int.Parse(Console.ReadLine());

            if (value == 1)
            {
                ReturnBook();
            }
            else if (value == 2)
            {
                studentClass();
            }
            else
            {
                Console.WriteLine("Invalid option");
            }
        }


    }
}


