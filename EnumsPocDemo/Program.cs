using EnumsPocDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsPocDemo
{
    internal class Program
    {
        public static void Main()
        {
            // Assigning value
            Console.WriteLine("1].Assigning value");
            Color color = Color.Black;
            Console.WriteLine("This is " + color + " Colour");

            // Getting the index value
            Console.WriteLine("\n2].Getting the index value");
            int colorindex = (int)Color.Blue;
            Console.WriteLine("Index of Blue Colour is " + colorindex);

            // Using Comparison operator
            Console.WriteLine("\n3].Using Comparison operator");
            if (color == Color.Black)
            {
                Console.WriteLine("It's Black"); 
            }

            //Parsing
            Console.WriteLine("\n4].Parsing");
            Color colorparsing = (Color)Enum.Parse(typeof(Color), "Violet");
            Console.WriteLine("Parsed Colour is " + colorparsing);

            // Using Foreach loop
            Console.WriteLine("\n5].Using Foreach loop");
            Console.WriteLine("List of all Colours");
            foreach (Color colour in Enum.GetValues(typeof(Color)))
            {
                Console.WriteLine(colour);
            }
        }
    }
}

