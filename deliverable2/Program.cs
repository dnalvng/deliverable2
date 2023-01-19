/*
 *Author: Denae Livingston
 *Date: 1/19/2023
 *Description: C# Console application for calculating letter grades
 */

using System;

namespace deliverable2;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a numeric grade: ");

        try
        {
            decimal grade = decimal.Parse(Console.ReadLine());

            string letter;

            if (grade >= 90)
            {
                letter = "A";
                Console.WriteLine("Your expected letter grade for ISM 4300 is A");

            }

            else if (grade >= 80 && grade < 90)
            {
                letter = "B";


            }
            else if (grade >= 70 && grade < 80)
            {
                letter = "C";

            }
            else if (grade >= 60 && grade < 70)
            {
                letter = "D";
            }
            else if (grade >= 0 && grade < 60)
            {
                letter = "F";
            }

                
        }
        catch
        {
            Console.WriteLine("Enter a nemeric value");
        }
        
        }
    }
       

