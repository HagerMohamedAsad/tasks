using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Program
    {
        static void GetTop(string[] name, int[] degree)
        {
            int index = 0;
            int max = 0;
            for (int i = 0; i < name.Length;i++ )
            {
                if (degree[i] > max) { 
                    max = degree[i];
                    index = i;
                }
            }
            Console.WriteLine("Top student name is : {0} and his/her score is {1}",name[index],degree[index]);
        }
        static void Search(string[]name,int[]degree) {
            Console.WriteLine("Please enter student name");
            string nam = Console.ReadLine();
            int index = Array.IndexOf(name, nam);
            if (index >= 0)
            {
                Console.WriteLine("student {0} score is : {1}", nam, degree[index]);
            }
            else {
                Console.WriteLine("Student not found");
            }
        }

        static void change(string[] name) {
            Console.WriteLine("Type the name of student to be changed (old name)");
            string OldNam = Console.ReadLine();
            Console.WriteLine("Enter new name");
            string NewNam = Console.ReadLine();
            int index = Array.IndexOf(name, OldNam);
            if (index >= 0)
            {
                name[index] = NewNam;
                Console.WriteLine("Name successfully changed from {0} to {1}", OldNam, name[index]);
            }
            else {
                Console.WriteLine("Student not found");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of students");
            int n = int.Parse(Console.ReadLine());
            string[] name = new string[n];
            int[] degree = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter student {0} name :", i+1);
                name[i] = Console.ReadLine();
                Console.WriteLine("Enter his/her degree");
                degree[i] =int.Parse( Console.ReadLine());
            }
            Console.WriteLine("Choose an option from the following menu");
            Console.WriteLine("========================================");
            Console.WriteLine("[1] search for a student degree");
            Console.WriteLine("[2] Get top student name and degree");
            Console.WriteLine("[3] Change a students name");
            Console.Write("Please enter your choice : ");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1) Search(name,degree);
            else if (choice == 2) GetTop(name, degree);
            else if (choice == 3) change(name);
        }
    }
}
