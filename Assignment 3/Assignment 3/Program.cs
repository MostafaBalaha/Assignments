using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Program
    {
        static string[] nameArr;
        static double[] mathDegrees;
        static int studentDegree(string sName)
        {
           
          int  studentIndex = Array.IndexOf(nameArr,sName);
          return studentIndex;
        }
        static int topStudent()
        {
            int max = 0;
            for(int i=0; i<mathDegrees.Length; i++)
            {
                if(mathDegrees[i] > mathDegrees[max])
                {
                    max = i;
                }
            }
            return max;
        }
        static void dataEntry()
        {
            int studentNo;
            Console.WriteLine("Enter Number Of Students");
            studentNo = int.Parse(Console.ReadLine());
             nameArr = new string[studentNo];
              mathDegrees = new double[studentNo];

            for (int i = 0; i < studentNo; i++)
            {
                Console.WriteLine("Enter Student {0} Name", i + 1);
                nameArr[i] = Console.ReadLine();
                Console.WriteLine("Enter Student {0} Degree", i + 1);
                mathDegrees[i] = double.Parse(Console.ReadLine());

            }
        }
        static void Main(string[] args)
        {
            dataEntry();
            Console.Clear();
            int userChoice;
            string menu = "Choose an option from the following menu \n";
            menu += "========================================\n";
            menu += "[1] Search for a student degree\n";
            menu += "[2] Get top student name and degree\n";
            menu += "[3] Change a student name\n";
            menu += "Please Enter Your Choice:";

            while (true)
            {
                Console.WriteLine(menu);
                userChoice = int.Parse(Console.ReadLine());
                if (userChoice == 1)
                {
                    Console.WriteLine("Enter Student name :D");
                    string name = Console.ReadLine();
                    int studentIndex = studentDegree(name);
                    if(studentIndex >= 0)
                    {
                        Console.WriteLine("Student {0} has a degree of {1}",nameArr[studentIndex],mathDegrees[studentIndex]);
                        Console.ReadLine();
                        Console.Clear();
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Not found");
                        Console.ReadLine();
                        Console.Clear();
                        continue;

                    }
                }
                else if (userChoice == 2)
                {
                    int max = topStudent();
                    Console.WriteLine("Top Student has name of {0} and Degree of {1}", nameArr[max],mathDegrees[max]);
                    Console.ReadLine();
                    Console.Clear();
                    continue;

                }else if(userChoice == 3)
                {
                    Console.WriteLine("Enter Student name :D");
                    string name = Console.ReadLine();
                    int studentIndex = studentDegree(name);
                    if (studentIndex >= 0)
                    {
                        Console.WriteLine("Enter New student name");
                        string newName = Console.ReadLine();
                        nameArr.SetValue(newName, studentIndex);
                        Console.WriteLine("Done");
                        Console.ReadLine();
                        Console.Clear();
                        continue;
                    }else
                    {
                        Console.WriteLine("Not Found");
                        Console.ReadLine();
                        Console.Clear();
                        continue;
                    }

                    }
                    else
                {
                    Console.WriteLine("Wrong Choice");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }
                

            }



        }
    }
}
