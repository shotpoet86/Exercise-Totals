/* Programmer: Austin Parker
   Date: March 29th, 2020
   Purpose: Displays weekly totals of students for each day and totals of revenue for gym.
 */

using System;
using static System.Console;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arrays and variable declerations. 
            int[,] zumba =
            {
                {12, 10, 17, 22},
                {11, 13, 17, 22},
                {12, 10, 22, 22},
                {9, 14, 17, 22},
                {12, 10, 21, 12},
                {12, 10, 5, 10}
            };

            int[,] spinning =
            {
                {7, 11, 15, 8},
                {9, 9, 9, 9},
                {3, 12, 13, 7},
                {2, 9, 9, 10},
                {8, 4, 9, 4},
                {4, 5, 9, 3}
            };
            string[] days = {"Monday     ", "Tuesday    ", "Wednesday", "Thursday", "Friday    ", "Saturday"};
            int totalRevenue = 0;
            int[] time = {1, 3, 5, 7};
            //Asks user for input of which class attended.
            WriteLine("Please enter the name of which exercise class you are taking either Zumba or Spinning.");
            string option = ReadLine();

            //Used only if user attends zumba class
            if (option == "Zumba" || option == "zumba")
            {
                Write("\t");

                for (int i = 0; i < time.Length; i++)
                {
                    Write("\t" + time[i] + ":00");
                }

                Write("\tTotal \tRevenue");

                //Loop instantiates array for attendance per day and revenue earned per day.
                for (int i = 0; i < zumba.GetLength(0); i++)
                {
                    int[] total = new int[days.Length];
                    int[] revenue = new int[days.Length];
                    Write("\n");
                    Write(days[i]);

                    //Calculates total atttendance per day and revenue earned.
                    for (int j = 0; j < zumba.GetLength(1); j++)
                    {
                        total[i] += zumba[i, j];
                        //Multiplies total attendance by 4 for price of zumba class.
                        revenue[i] = total[i] * 4;
                        //Displays zumba attendance per day 
                        Write("\t" + zumba[i, j]);
                    }

                    totalRevenue += revenue[i];
                    Write("\t" + total[i] + "\t$" + revenue[i]);
                }

                WriteLine("\n");
                Write("----------------------------" +
                      "--------------------------------" + "\n");
                Write("Total\t");

                //Loop will display totals for revenue for all days of zumba class.
                int[] totalOne = new int[4];
                for (int j = 0; j < zumba.GetLength(1); j++)
                {
                    for (int i = 0; i < zumba.GetLength(0); i++)
                    {
                        totalOne[j] += zumba[i, j];
                    }

                    Write("\t" + totalOne[j]);
                }

                Write("\t\t$" + totalRevenue);
                Write("\n\nThanks for using the Exercise program! Press any key to close program.");
                Read();
            }

            //Used only if user attends spin class.
            else if (option == "Spinning" || option == "spinning")
            {
                Write("\t");

                for (int i = 0; i < time.Length; i++)
                {
                    int spinTime = time[i] + 1;
                    Write("\t" + spinTime + ":00");
                }

                Write("\tTotal \tRevenue");

                //Loop instantiates array for attendance per day and revenue earned per day.
                for (int i = 0; i < spinning.GetLength(0); i++)
                {
                    int[] total = new int[days.Length];
                    int[] revenue = new int[days.Length];
                    Write("\n");
                    Write(days[i]);

                    //Calculate total atttendance per day and revenue earned.
                    for (int j = 0; j < spinning.GetLength(1); j++)
                    {
                        total[i] += spinning[i, j];
                        //Multiplies total attendance by 5 for price of spin class.
                        revenue[i] = total[i] * 5;

                        //Displays spinning attendance per day 
                        Write("\t" + spinning[i, j]);
                    }

                    //Calculate total revenue earned
                    totalRevenue += revenue[i];
                    //Displays total attendance and revenue earned per day
                    Write("\t" + total[i] + "\t$" + revenue[i]);
                }

                WriteLine("\n");
                Write("----------------------------" +
                      "--------------------------------" + "\n");
                Write("Total\t");

                //Loop will display totals for revenue for all days of spin class.
                int[] totalOne = new int[4];
                for (int j = 0; j < spinning.GetLength(1); j++)
                {
                    for (int i = 0; i < spinning.GetLength(0); i++)
                    {
                        totalOne[j] += spinning[i, j];
                    }

                    Write("\t" + totalOne[j]);
                }

                Write("\t\t$" + totalRevenue);
                Write("\n\nThanks for using the Exercise program! Press any key to close program.");
                Read();
            }

            //If incorrect input is used.
            else
                Write("Sorry, that is not a vaild input.");
        }
    }
}