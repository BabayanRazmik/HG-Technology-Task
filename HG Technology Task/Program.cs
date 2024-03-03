using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HG_Technology_Task
{
    internal class Program
    {
        #region Methods

        #region Change Numbers List

        public static List<string> ChangeNumbersList(List<int> numbers, int firstNumber, int secondNumber, string firstWord, string secondWord,
                                                     int previousVersionFirstNumber = 0, int previousVersionSecondNumber = 0,
                                                     string previousVersionFirstWord = "", string previousVersionSecondWord = "",
                                                     string thirdWord = "")
        {
            List<string> changeNumberList = new List<string>();

            foreach (var number in numbers)
            {
                changeNumberList.Add(GetReplacement(number, firstNumber, secondNumber, firstWord, secondWord,
                                                      previousVersionFirstNumber, previousVersionSecondNumber,
                                                      previousVersionFirstWord, previousVersionSecondWord,
                                                      thirdWord));
            }

            return changeNumberList;
        }

        #endregion

        #region Get Replacement Number

        private static string GetReplacement(int number, int firstNumber, int secondNumber, string firstWord, string secondWord,
                                                     int previousVersionFirstNumber = 0, int previousVersionSecondNumber = 0,
                                                     string previousVersionFirstWord = "", string previousVersionSecondWord = "",
                                                     string thirdWord = "")
        {
            string replacement = "";

            if (number % firstNumber == 0)
            {
                replacement += firstWord;
            }
            if (number % secondNumber == 0)
            {
                if (thirdWord.Length > 0 && replacement.Length > 0)
                {
                    replacement = thirdWord;
                }
                else
                {
                    replacement += replacement.Length > 0 ? "-" + secondWord : secondWord;
                }
            }
            if (number % previousVersionFirstNumber == 0)
            {
                replacement += replacement.Length > 0 ? "-" + previousVersionFirstWord : previousVersionFirstWord;
            }
            if (number % previousVersionSecondNumber == 0)
            {
                replacement += replacement.Length > 0 ? "-" + previousVersionSecondWord : previousVersionSecondWord;
            }

            return string.IsNullOrEmpty(replacement) ? number.ToString() : replacement;
        }

        #endregion

        #endregion

        static void Main(string[] args)
        {

            #region User enter list numbers

            Console.WriteLine("Enter list of numbers:");
            Console.WriteLine("After each digit, click on the enter:");
            Console.WriteLine("Enter a non-numeric value to stop:\n");

            List<int> numbers = new List<int>();

            while (true)
            {
                Console.Write("-> ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int number))
                {
                    numbers.Add(number);
                }
                else
                {
                    // If a non-numeric value is entered, break out of the loop
                    break;
                }
            }

            #endregion

            #region Print and Check list numbers

            if (numbers.Count > 0)
            {
                Console.WriteLine("\nEntered numbers:");

                foreach (int num in numbers)
                {
                    Console.Write($"{num} ");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("There is no point in continuing the process because you have entered an empty list");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.ReadKey();
                Environment.Exit(0);
            }

            #endregion

            #region Readme

            Console.WriteLine("\n\nVersion 1:\n" +
                              "If number % 3 = 0 , replace it with \"fizz\"\n" +
                              "If number % 5 = 0 , replace it with \"buzz\"\n" +
                              "If number % 3 = 0 AND number % 5 = 0, replace it with \"fizz-buzz\"");

            Console.WriteLine("\nVersion 2:\n" +
                              "If number % 7 = 0 , replace it with \"guzz\"\n" +
                              "If number % 4 = 0 , replace it with \"muzz\"\n" +
                              "If number % 7 = 0 AND number % 4 = 0 , replace it with \"muzz-guzz\"\n" +
                              "plus Version 1 effect\n");

            Console.WriteLine("\nVersion 3:\n" +
                              "If number % 3 = 0 , replace it with \"dog\"\n" +
                              "If number % 5 = 0 , replace it with \"cat\"\n" +
                              "If number % 3 = 0 AND number % 5 = 0 , replace it with \"good-boy\"\n" +
                              "plus Verion 2 effect\n");

            Console.WriteLine("\nVersion 4:\n" +
                              "The user writes conditions in the same way as version 1:");

            #endregion

            List<string> changeNumbersList = new List<string>();

            #region Enter Version

            while (true)
            {
                Console.Write("\nPlease Enter Version 1, 2, 3 or 4: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int number))
                {
                    Console.WriteLine("\nYour version: " + number);
                    if (number > 0 && number < 5)
                    {
                        switch (number)
                        {
                            case 1:
                                changeNumbersList = ChangeNumbersList(numbers, 3, 5, "fizz", "buzz");
                                break;
                            case 2:
                                changeNumbersList = ChangeNumbersList(numbers, 3, 5, "fizz", "buzz", 4, 7, "muzz", "guzz");
                                break;
                            case 3:
                                changeNumbersList = ChangeNumbersList(numbers, 3, 5, "dog", "cat", 4, 7, "muzz", "guzz", "good-boy");
                                break;
                            case 4:
                                #region Other User Version

                                try
                                {
                                    Console.Write("\nEnter first number: ");
                                    int firstNumber = Convert.ToInt32(Console.ReadLine());

                                    Console.Write("\nEnter second number: ");
                                    int secondNumber = Convert.ToInt32(Console.ReadLine());

                                    Console.Write("\nEnter first word: ");
                                    string firstWord = Console.ReadLine();

                                    Console.Write("\nEnter second word: ");
                                    string secondWord = Console.ReadLine();

                                    changeNumbersList = ChangeNumbersList(numbers, firstNumber, secondNumber, firstWord, secondWord);

                                    #region Print list

                                    Console.WriteLine("\nEntered numbers:");

                                    foreach (var item in changeNumbersList)
                                    {
                                        Console.Write($"{changeNumbersList} ");
                                    }

                                    #endregion
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex.Message);
                                    throw;
                                }

                                #endregion
                                break;
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\nYou have chosen the wrong version\nPlease choose the correct version");
                    }
                }
                else
                {
                    Console.WriteLine("\nPlease write integer!");
                }
            }

            #endregion

            #region Print Changed Numbers List
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nYour changed list: ");

            foreach (string item in changeNumbersList)
            {
                Console.Write($"{item} ");
            }

            Console.ForegroundColor = ConsoleColor.Black;

            #endregion

            Console.ReadKey();
        }
    }
}
