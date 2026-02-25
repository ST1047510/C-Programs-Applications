// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections;

namespace StudentMarkList
{
    public class program
    {
        public static void Main(string[] args)
        {
            //Loop Reapeat
            for (int i = 1; i <= 5; i++)
            {
                //dechalre variable
                string studentname;
                int mark;

                //Ask user input
                Console.WriteLine("Student: " + i);

                Console.Write("Enter Student Name:");
                studentname = Console.ReadLine();

                Console.Write("Enter Student Mark 0-100:");
                mark = Convert.ToInt32(Console.ReadLine());

                if (mark >= 50)
                {
                    Console.WriteLine(studentname + "  Passed");
                }
                else
                { 
                    Console.WriteLine(studentname + " Failed");    
                }
                Console.WriteLine(); //Empty Line
            }
            Console.ReadLine();
        }
    } 
}