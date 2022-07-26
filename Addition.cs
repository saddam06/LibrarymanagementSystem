using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementSystem
{
    internal class Addition
    {
        public static List<Book> books = new List<Book>
        {
            new Book{ID=1,Name="Book1",AUTHORNAME="saddam",PRICE=100 },
            new Book{ID=2,Name="Book2",AUTHORNAME="saddam2",PRICE=101 },




        };

        public void ADD(Book NewBook)
        {
            if (books == null)
            {
                books = new List<Book>();

            }
            books.Add(NewBook);

        }

        public void Rem(int i)
        {
            if (books != null)
            {
                books.RemoveAll(r => r.ID == i);

            }

        }


        public IEnumerator GetEnumerator()
        {
            if (books != null)
            {
                return books.GetEnumerator();
            }
            else
            {
                return null;
            }

        }

    }



    public class Book
    {
        public Boolean IsBorrowed
        { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }
        public string AUTHORNAME { get; set; }
        public int PRICE { get; set; }
    }
}