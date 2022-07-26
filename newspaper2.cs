using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementSystem
{
    internal class Newspaper2 : IEnumerable
    {
        public static List<newsPaper> Newspapers = new List<newsPaper>
        {
            new newsPaper{Name="bharat samachar" },
            new newsPaper{Name="india Today"  },
            new newsPaper{Name="Dainik jagran" },
            new newsPaper{Name="Sahara" }
        };

        public IEnumerator GetEnumerator()
        {
            if (Newspapers != null)
            {
                return Newspapers.GetEnumerator();
            }
            else
            {
                return null;
            }

        }


    }


    public class newsPaper
    {
        public string Name { get; set; }
    }
}
