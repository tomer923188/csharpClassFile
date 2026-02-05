using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void sumcalc()
        {
            int num = 0;
            int sum = 0;

            while (sum < 100)
            {
                Console.Write("Enter a number: ");
                num = int.Parse(Console.ReadLine());
                sum += num;
            }
            Console.WriteLine("The total sum is " + sum);
        }
        static void Read3even()
        {
            int count = 0, num;

            while (count < 3)
            {
                Console.Write("Enter a number: ");
                num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                    count++;
            }
        }
        static void readtill3digitnumber()
        {
            int num = 0;

            while (num < 100 || num > 999)
            {
                Console.Write("Enter a 3-digit number: ");
                num = int.Parse(Console.ReadLine());
            }

        }
        static void group2()
        {
            for (int k=7;k>=1;k--)
            {
                for (int j = 1; j <= k; j++)
                {
                    Console.Write(j + "");
                }
                Console.WriteLine();
            }
        }
        static void printingtriangle()
        {
            Console.Write("How many rows do you want: ");
            int rows = int.Parse(Console.ReadLine());

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= rows - i; j++);
                Console.WriteLine(" ");
                for (int k = 1; k <= i; k++)
                    Console.WriteLine(i);
                Console.WriteLine();
                
            }
        }
        static void printingshape()
        {
            Console.Write("Enter the amount of rows: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Enter the amount of cols: ");
            int cols = int.Parse(Console.ReadLine());

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        static void littertask()
        {
            int days = 7;
            double litters = 0;
            bool under1 = false;
            double sum = 0;
            int daysover3 = 0;

            for (int i = 0; i < days; i++)
            {
                under1 = false;
                Console.Write("Enter the amount of litters: ");
                litters = double.Parse(Console.ReadLine());
                sum += litters;

                if (litters < 1)
                {
                    under1 = true;
                }

                if (litters < 3)
                {
                    daysover3++;
                }

                Console.WriteLine("The sum is: " + sum);
            }

        }

        static void whilepractice()
        {
            while (true)
            {
                Console.WriteLine("\nChoose one of the following options:\n1- Squared Value\n2- Line of stars\n0- Exit");
                Console.Write("Enter your choice --> ");

                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Console.Write("Enter a number: ");
                    double input = double.Parse(Console.ReadLine());
                    Console.WriteLine(input * input);
                }
                else if (choice == 2)
                {
                    Console.Write("Enter the amount of stars you want: ");
                    int input = int.Parse(Console.ReadLine());

                    for (int i = 0; i < input; i++)
                    {
                        Console.Write("*");
                    }
                }
                else if (choice == 0)
                {
                    Console.WriteLine("See you later aligator");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid number");
                    break;
                }
            }
        }

        static void IsPalindrome(int num)
        {
            int digit, newNum = 0, n = num;
            while (num > 0)
            {
                digit = num % 10;
                newNum = newNum * 10 + digit;
                n /= 10;
            }
            if (newNum == num) ;
        }

        static void maharach()
        {
            int[] numbers = new int[5];
            numbers[0] = 5;
            numbers[2] = 7;
            numbers[4] = 6;

        }

        static int[] copyarr(int[] arr)
        {
            int[] newArry = new int[arr.Length];
            for (int i = 0; i < newArry.Length; i++)
            {
                newArry[1] = arr[i];
            }
            return newArry;
        }
        static void arr()
        {
            int[] arr1 = { 1, 2, 3 };
            int[] arr2 = copyarr (arr1);
            int i = 0;
        }

        static void stupidshitidksomeshitwithnumbersandarraysidk()
        {
            int[] grades = new int[10];
            int i = 0;
            int sum = 0;
            double avg = 0;
            int counter = 0;
            Random rand = new Random();

            Console.WriteLine("the grades are: ");
            for (i = 0; i < grades.Length; i++)
            {
                grades[i] = rand.Next(0, 101);
                Console.Write(grades[i] + " ");
            }


            Console.WriteLine();
            for (i = 0; i < grades.Length; i++)
            {
                if (grades[i] >= 55)
                {
                    counter++;
                }
                sum += grades[i];
            }

            avg = (double)sum / grades.Length;
            Console.WriteLine("the avg is " + avg + " and the number of grades that passed: " + counter);
        }

        static void taskarray()
        {
            int[] arr1 = { 1, 2, 3, 4, 5 };
            int[] arr2 = new int[5];

            for (int i = 0; i < arr1.Length; i++)
            {
                arr2[i] = arr1[i];
                Console.WriteLine(arr2[i]);
            }
        }

        static void printarray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++) ;
            {
                Console.WriteLine(arr[1] + " ");
            }
        }

        static void PrintHistogram(int[] arr) // idk whats wrong with this
        {
            Console.WriteLine("There are" + arr.Length + "numbers in the array: ");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + ": ");
                for (int j = 0; i < arr[i]; j++)
                {

                    Console.WriteLine("*");
                    Console.WriteLine();
                }
            }
        }

        static bool IsSymetricArray(int[] arr)
        {
            int left = 0, right = arr.Length - 1;
            bool isSymetric = true;

            while (left < right && isSymetric)
            {
                if (arr[left] != arr[right])
                    isSymetric = false;

                left++;
                right--;
            }
            
            return isSymetric;
        }

        static void Main(string[] args)
        {
            //sumcalc();
            //Read3even();
            //readtill3digitnumber();
            //group2();
            //printingtriangle();
            //littertask();
            //printingshape();
            //whilepractice();
            //stupidshitidksomeshitwithnumbersandarraysidk();
            //taskarray();
            //PrintHistogram();
            IsSymetricArray(arr);
        }
    }
}
