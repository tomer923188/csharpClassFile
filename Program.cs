using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void CalculateSum()
        {
            int sum = 0;

            while (sum < 100)
            {
                Console.Write("Enter a number: ");
                if (int.TryParse(Console.ReadLine(), out int num))
                {
                    sum += num;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
            }

            Console.WriteLine($"The total sum is {sum}");
        }

        static void ReadThreeEvenNumbers()
        {
            int evenCount = 0;

            while (evenCount < 3)
            {
                Console.Write("Enter a number: ");
                if (int.TryParse(Console.ReadLine(), out int num) && num % 2 == 0)
                {
                    evenCount++;
                }
            }

            Console.WriteLine("Three even numbers have been entered.");
        }

        static void ReadUntilThreeDigitNumber()
        {
            int num = 0;

            while (num < 100 || num > 999)
            {
                Console.Write("Enter a 3-digit number: ");
                int.TryParse(Console.ReadLine(), out num);
            }

            Console.WriteLine($"Valid 3-digit number entered: {num}");
        }

        static void PrintNumberTriangle()
        {
            for (int row = 7; row >= 1; row--)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(col);
                }
                Console.WriteLine();
            }
        }

        static void PrintNumberPyramid()
        {
            Console.Write("How many rows do you want: ");
            if (int.TryParse(Console.ReadLine(), out int rows))
            {
                for (int i = 1; i <= rows; i++)
                {
                    for (int j = 1; j <= rows - i; j++)
                    {
                        Console.Write(" ");
                    }

                    for (int k = 1; k <= i; k++)
                    {
                        Console.Write(i + " ");
                    }
                    Console.WriteLine();
                }
            }
        }

        static void PrintRectangle()
        {
            Console.Write("Enter the number of rows: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of columns: ");
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

        static void CalculateLiterStatistics()
        {
            int days = 7;
            double totalLiters = 0;
            int daysOverThreeLiters = 0;

            for (int i = 0; i < days; i++)
            {
                Console.Write($"Enter the amount of liters for day {i + 1}: ");
                double liters = double.Parse(Console.ReadLine());

                totalLiters += liters;
                bool isUnderOneLiter = liters < 1;

                if (liters >= 3)
                {
                    daysOverThreeLiters++;
                }

                Console.WriteLine($"Running sum is: {totalLiters}");
            }

            Console.WriteLine($"Days over 3 liters: {daysOverThreeLiters}");
        }

        static void ShowMenuAndExecute()
        {
            while (true)
            {
                Console.WriteLine("\nChoose one of the following options:\n1 - Squared Value\n2 - Line of stars\n0 - Exit");
                Console.Write("Enter your choice --> ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                if (choice == 1)
                {
                    Console.Write("Enter a number: ");
                    double input = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Result: {input * input}");
                }
                else if (choice == 2)
                {
                    Console.Write("Enter the amount of stars you want: ");
                    int input = int.Parse(Console.ReadLine());

                    for (int i = 0; i < input; i++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                else if (choice == 0)
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid number choice.");
                }
            }
        }

        static bool IsPalindrome(int originalNum)
        {
            int newNum = 0;
            int tempNum = originalNum;

            while (tempNum > 0)
            {
                int digit = tempNum % 10;
                newNum = (newNum * 10) + digit;
                tempNum /= 10;
            }

            return newNum == originalNum;
        }

        static void InitializeBasicArray()
        {
            int[] numbers = new int[5];
            numbers[0] = 5;
            numbers[2] = 7;
            numbers[4] = 6;
        }

        static int[] CopyArray(int[] originalArray)
        {
            int[] newArray = new int[originalArray.Length];
            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = originalArray[i];
            }
            return newArray;
        }

        static void TestArrayCopy()
        {
            int[] original = { 1, 2, 3 };
            int[] copy = CopyArray(original);
        }

        static void CalculateGradeStatistics()
        {
            int[] grades = new int[10];
            int sum = 0;
            int passedCount = 0;
            Random random = new Random();

            Console.WriteLine("The grades are: ");
            for (int i = 0; i < grades.Length; i++)
            {
                grades[i] = random.Next(0, 101);
                Console.Write(grades[i] + " ");
                sum += grades[i];

                if (grades[i] >= 55)
                {
                    passedCount++;
                }
            }

            Console.WriteLine();
            double average = (double)sum / grades.Length;
            Console.WriteLine($"The average is {average:F2} and the number of passing grades: {passedCount}");
        }

        static void CopyFixedArray()
        {
            int[] originalArray = { 1, 2, 3, 4, 5 };
            int[] newArray = new int[5];

            for (int i = 0; i < originalArray.Length; i++)
            {
                newArray[i] = originalArray[i];
                Console.WriteLine(newArray[i]);
            }
        }

        static void PrintArray(int[] arrayToPrint)
        {
            for (int i = 0; i < arrayToPrint.Length; i++)
            {
                Console.Write(arrayToPrint[i] + " ");
            }
            Console.WriteLine();
        }

        static void PrintHistogram(int[] data)
        {
            Console.WriteLine($"There are {data.Length} numbers in the array:");

            for (int i = 0; i < data.Length; i++)
            {
                Console.Write($"{data[i]}: ");

                for (int j = 0; j < data[i]; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static bool IsSymmetricArray(int[] arrayToCheck)
        {
            int leftIndex = 0;
            int rightIndex = arrayToCheck.Length - 1;
            bool isSymmetric = true;

            while (leftIndex < rightIndex && isSymmetric)
            {
                if (arrayToCheck[leftIndex] != arrayToCheck[rightIndex])
                {
                    isSymmetric = false;
                }

                leftIndex++;
                rightIndex--;
            }

            return isSymmetric;
        }

        static void CountLetterFrequencies()
        {
            char[] characters = { 'a', 'b', 'c', 'd', 'a' };
            int[] letterCounts = new int[26];
            int asciiOffset = 'a';

            foreach (char c in characters)
            {
                int index = c - asciiOffset;
                letterCounts[index]++;
            }

            for (int i = 0; i < letterCounts.Length; i++)
            {
                if (letterCounts[i] > 0)
                {
                    char currentLetter = (char)(i + asciiOffset);
                    Console.WriteLine($"The letter '{currentLetter}' shows up {letterCounts[i]} times.");
                }
            }
        }

        static void CheckIfArrayAscends()
        {
            int[] numbers = { 1, 2, 6, 2, 4 };
            bool isAscending = true;

            for (int i = 0; i < numbers.Length - 1 && isAscending; i++)
            {
                if (numbers[i] >= numbers[i + 1])
                {
                    isAscending = false;
                }
            }

            Console.WriteLine(isAscending ? "The array is going up" : "The array is not going up");
        }

        static void CheckIfArrayIsHalved()
        {
            int[] numbers = { 1, 5, 9, 1, 5, 9 };
            bool halvesMatch = true;

            if (numbers.Length % 2 == 0)
            {
                int midPoint = numbers.Length / 2;
                for (int i = 0; i < midPoint && halvesMatch; i++)
                {
                    if (numbers[i] != numbers[midPoint + i])
                    {
                        halvesMatch = false;
                    }
                }
            }
            else
            {
                halvesMatch = false;
            }

            Console.WriteLine(halvesMatch ? "Halves match" : "Halves do not match");
        }

        static void MergeMaxFromTwoArrays()
        {
            int[] arrayA = { 3, 7, 12, 19, 25, 31, 42, 56, 68, 90 };
            int[] arrayB = { 3, 14, 22, 37, 12, 30, 63, 78, 64, 100 };
            int[] mergedMaxArray = new int[10];

            for (int i = 0; i < arrayA.Length; i++)
            {
                if (arrayA[i] > arrayB[i])
                {
                    mergedMaxArray[i] = arrayA[i];
                }
                else if (arrayA[i] < arrayB[i])
                {
                    mergedMaxArray[i] = arrayB[i];
                }
                else
                {
                    mergedMaxArray[i] = 0;
                }
            }

            Console.WriteLine(string.Join(", ", mergedMaxArray));
        }

        static void FindMostFrequentElement()
        {
            int[] numbers = { 1, 6, 6, 6, 1, 6, 1 };
            int mostFrequentNumber = 0;
            int maxOccurrences = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentCount = 0;

                for (int j = i; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        currentCount++;
                    }
                }

                if (currentCount > maxOccurrences)
                {
                    maxOccurrences = currentCount;
                    mostFrequentNumber = numbers[i];
                }
            }

            Console.WriteLine($"The most frequent number is {mostFrequentNumber}, showing up {maxOccurrences} times.");
        }

        static void TallyVotes()
        {
            string[] candidates = { "Candidate 1", "Candidate 2", "Candidate 3", "Candidate 4", "Candidate 5",
                                    "Candidate 6", "Candidate 7", "Candidate 8", "Candidate 9", "Candidate 10" };
            int[] voteCounts = new int[candidates.Length];

            while (true)
            {
                Console.WriteLine("\nEnter a number between 1 to 10 to vote for a candidate, or 0 to exit:");

                for (int i = 0; i < candidates.Length; i++)
                {
                    Console.WriteLine($"{i + 1} - {candidates[i]}");
                }

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                if (choice == 0)
                {
                    Console.WriteLine("Thanks for voting!");
                    break;
                }

                if (choice < 1 || choice > 10)
                {
                    Console.WriteLine("Choice is out of range. Try again.");
                    Console.WriteLine("----------------------------------------");
                }
                else
                {
                    voteCounts[choice - 1]++;
                }
            }

            int maxVotes = 0;
            string winner = "";

            for (int i = 0; i < candidates.Length; i++)
            {
                if (voteCounts[i] > maxVotes)
                {
                    maxVotes = voteCounts[i];
                    winner = candidates[i];
                }
            }

            Console.WriteLine($"\nThe winner is {winner} who got {maxVotes} votes.");
        }

        static void CountSmallerElements()
        {
            int[] numbers = { 42, 67, 89, 16, 53, 24, 91, 3, 68, 77, 12, 59, 34, 85, 20 };

            Console.Write("Enter a number to search: ");
            int targetNum = int.Parse(Console.ReadLine());

            bool isInside = false;
            int foundIndex = -1;
            int smallerCount = 0;

            for (int i = 0; i < numbers.Length && !isInside; i++)
            {
                if (numbers[i] == targetNum)
                {
                    isInside = true;
                    foundIndex = i;
                }
            }

            if (isInside)
            {
                for (int i = 0; i < foundIndex; i++)
                {
                    if (numbers[i] < targetNum) smallerCount++;
                }
                Console.WriteLine($"The number {targetNum} is inside. There are {smallerCount} smaller numbers before it.");
            }
            else
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] < targetNum) smallerCount++;
                }
                Console.WriteLine($"The number {targetNum} is not inside. There are {smallerCount} smaller numbers in total.");
            }
        }

        static void FilterAndReplaceZeros()
        {
            Random random = new Random();
            int[] beforeArray = new int[30];
            int[] afterArray = new int[30];
            int j = 0;

            for (int i = 0; i < beforeArray.Length; i++)
            {
                beforeArray[i] = random.Next(0, 6);
                Console.Write(beforeArray[i] + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < beforeArray.Length; i++)
            {
                if (beforeArray[i] != 0)
                {
                    afterArray[j] = beforeArray[i];
                    j++;
                }
            }

            for (int i = 0; i < afterArray.Length; i++)
            {
                if (afterArray[i] == 0)
                {
                    afterArray[i] = 1;
                }
                Console.Write(afterArray[i] + " ");
            }
            Console.WriteLine();
        }

        static void ProcessGrades()
        {
            int[] grades = new int[8];
            int sum = 0;
            int aboveAverageCount = 0;

            for (int i = 0; i < grades.Length; i++)
            {
                Console.Write($"Enter grade {i + 1}: ");
                grades[i] = int.Parse(Console.ReadLine());
                sum += grades[i];
            }

            double average = (double)sum / grades.Length;
            Console.WriteLine($"\nYour average grade is: {average:F2}");

            foreach (int grade in grades)
            {
                if (grade > average)
                {
                    aboveAverageCount++;
                    Console.WriteLine($"The grade {grade} is above average.");
                }
            }

            Console.WriteLine($"Total grades above average: {aboveAverageCount}");
        }

        static void RestrauntOrder()
        {
            int[] arr = new int[3];
            string[] food = { "pizza", "salad", "pasta" };
            int sum = 0;
            int max = 0;
            int maxIndex = 0;
            int choice = 0;
            int amount = 0;

            while (true)
            {
                Console.Write("Enter the number 1 for pizza: ");
                Console.Write("Enter the number 2 for salad: ");
                Console.Write("Enter the number 3 for pasta: ");
                Console.Write("Enter the number 0 to exit: ");
                choice = int.Parse(Console.ReadLine());
                
                if (choice == 1)
                {
                    Console.WriteLine("Enter the amount you want: ");
                    amount = int.Parse(Console.ReadLine());

                }
                    
            }
        }

        static void MostFrequentNumber()
        {
            int[] arr = new int[100];
            Random rnd = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(25, 96);
                Console.Write(arr[i] + " ");

                
            }
            Console.WriteLine("The most frequent number is: ");
        }



        static void Main(string[] args)
        {
            // CalculateSum();
            // ReadThreeEvenNumbers();
            // ReadUntilThreeDigitNumber();
            // PrintNumberTriangle();
            // PrintNumberPyramid();
            // CalculateLiterStatistics();
            // PrintRectangle();
            // ShowMenuAndExecute();
            // InitializeBasicArray();
            // CopyFixedArray();
            // CountLetterFrequencies();
            // CheckIfArrayAscends();
            // CheckIfArrayIsHalved();
            // MergeMaxFromTwoArrays();
            // FindMostFrequentElement();
            // TallyVotes();
            // CountSmallerElements();
            // FilterAndReplaceZeros();
            //ProcessGrades();
            //MostFrequentNumber();
        }
    }
}
