// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections;

namespace ASCIIvalue
{
    public class program
    {
        public static void Main(string[] args)
        {
            //declare arraylist
            ArrayList charlist = new ArrayList();

            //Prompt user to enter 8 characters
            Console.WriteLine("Hi Please enter 8 Characters: ");

            for(int i = 0;i < 8; i++)
            {
                Console.WriteLine("character" +  (i  +  1)  +  ": ");
                char character = Convert.ToChar(Console.ReadLine());
                charlist.Add(character);
            }
            //Display ASCII Values
            Console.WriteLine("\nASCII Values");

            foreach(char character in charlist)
            {
                int ascii = (int) character;
                Console.WriteLine("ASCII Value of : "+  character +  "is "  + ascii);
            }
            Console.ReadLine();

        }

    }
}