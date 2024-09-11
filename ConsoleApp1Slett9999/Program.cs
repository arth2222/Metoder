using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1Slett9999
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string test = "123 ";
            string trimmet=test.Trim();
        }

        public static void SkrivHei()
        {

        }

        public static string ReturnerHei()
        {
            string bolle = "Hei";
            return bolle;
        }

        public static void SkrivNoe(string tekst)
        {
            Console.WriteLine(tekst);
        }


        // Function to remove a character at the specified index
        public static string remove_char(string str, int n)
        {
            return str.Remove(0, 5); // Using Remove method to eliminate the character at index n
        }


        public static int Add(int tall1, int tall2)
        {
            return tall1 + tall2;
        }
    }
}
