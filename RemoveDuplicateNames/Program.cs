using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RemoveDuplicateNames
{
    class Program
    {
        static void Main(string[] args)
        {
            string names;
            do
            {
                Console.Write("Please enter a list of names (separated by space):");
                names = Console.ReadLine();
                try
                {
                    List<string> lstNames = RemoveDuplicates(names.Split(new char[] {' '}).ToList());
                    Console.WriteLine(string.Join(", ",lstNames));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (names.Length > 0);
        }

        static List<string> RemoveDuplicates(List<string> names)
        {
            List<string> lstNames = new List<string>();
            string strNames = string.Join(",", names) + ",";

            foreach(string name in names)
            {
                if (strNames.Length == 0)
                    break;

                if (strNames.Contains(name + ","))
                {
                    strNames = strNames.Replace(name + ",", "");
                    lstNames.Add(name);
                }
            }

            return lstNames;
        }
    }
}
