/*Line of code, 27 to 65, made by Emre Biberoglu CCC 2022 Programming 1*/
using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureGame
{
    internal static class Utility
    {
        public static void TypewriteFast(string message)
        {
            for (int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i]);
                System.Threading.Thread.Sleep(5);
            }
        }
        public static void Typewrite(string message)
        {
            for (int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i]);
                System.Threading.Thread.Sleep(60);
            }
        }

        public static int ShowUserOptionsAndGetAValidResponse(string title, string Extra, List<string> items)
        {
            return ShowUserOptionsAndGetAValidResponse(title, Extra, items.ToArray());
        }
        public static int ShowUserOptionsAndGetAValidResponse(string title, string Extra, string[] items)
        {
            Console.WriteLine(title);
            for (int i = 0; i < items.Length; i++)
            {
                int roomNumber = i + 1;
                string details = $"{roomNumber}) {items[i]}";
                Console.WriteLine(details);
            }
            string extraTitle = $"{Extra}";
            Console.WriteLine(extraTitle);
            

            return GetAValidNumberFromTheUser(items.Length + 1);
        }
        public static int GetAValidNumberFromTheUser(int numberOfItems)
        {
            try
            {
                int number = Convert.ToInt32(Console.ReadLine());
                if (number > 0 && number <= numberOfItems)
                {
                    number--;
                    //Console.WriteLine($"Thank you for choosing a valid number {number}");
                    return number;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("You didn't enter a valid number");
                //Console.WriteLine("0 cannot be divided by 0");
            }
            //Recursive function
            return GetAValidNumberFromTheUser(numberOfItems);
        }

        public static int GetRandomNumber()
        {
            return RandomNumber();
        }
        public static int RandomNumber()
        {
            Random random = new Random();
            int number = 0;
            number = random.Next(10);
            random.Next(1, 11);
            return number;
        }
    }
}
