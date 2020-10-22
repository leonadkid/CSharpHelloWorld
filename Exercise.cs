using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorld.Exercises
{
    public class Exercises
    {
        public static void NumberBetween1And10()
        {
            Console.WriteLine("Please enter a number between 1 and 10");
            int number = Convert.ToInt32(Console.ReadLine());
            if(number >= 1 && number <=10)
                Console.WriteLine("Valid");
            else
                Console.WriteLine("Invalid");
        }

        public static void Maximum2Numbers()
        {
            Console.WriteLine("please enter number 1");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter number 2");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Maximum number is:");

            if (number1 >= number2)
                Console.WriteLine(number1);
            else
                Console.WriteLine(number2);
        }

        public static void CheckImage() 
        {
            Console.WriteLine("please enter the width of image");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the height if image");
            int height = Convert.ToInt32(Console.ReadLine());
            string image = (width > height) ? "landscape" : " portrait";
            Console.WriteLine(String.Format("The image is {0}", image));
        }

        public static void SpeedCamera()
        {
            Console.WriteLine("please set the speed limit");
            int speedLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter the car speed");
            int carSpeed = Convert.ToInt32(Console.ReadLine());
            var demerit = MathF.Truncate((speedLimit-carSpeed)/5);
            if(demerit < 12)
                Console.WriteLine(String.Format("Current demerit is {0}", demerit));
            else
                Console.WriteLine("License Suspended");
        }

        public static int TotalNumberDivisibleBy3() 
        {
            int totalNumbers = 0;
            for (int i = 1; i <= 100; i++) 
            {
                if (i % 3 == 0)
                    totalNumbers++;
            }
            return totalNumbers;
        }

        public static void SumOfEnteredNumber()
        {
            int totalNumber = 0;
            string enterString;
            do
            {
                Console.WriteLine("Enter a number: ");
                enterString = Console.ReadLine();
                if (!enterString.ToLower().Equals("ok"))
                    totalNumber += Convert.ToInt32(enterString);
            }
            while (!enterString.ToLower().Equals("ok"));

            Console.WriteLine(String.Format("Total number: {0}", totalNumber));
        }

        public static int Factotial(int n)
        {
            if (n <= 1)
                return 1;
            else
            {
                return n * Factotial(n - 1);
            }
        }

        public static void RandomNumber()
        {
            Random random = new Random();
            int number = random.Next(1, 10);
            Console.WriteLine(String.Format("Random number is {0}", number));
            bool flag = false;
            for (int i = 0; i < 4 ; i++)
            {
                Console.WriteLine("please guess the random number :)");
                int guessNumber = Convert.ToInt32(Console.ReadLine());
                if (guessNumber == number)
                {
                    flag = true;
                    Console.WriteLine("You WON");
                    break;
                }
                else
                {
                    Console.WriteLine("You lose");
                }
            }
        }

        public static void MaximumNumberInListEntered()
        {
            Console.WriteLine("Please enter list of interger separated by comma: ");
            string inputString = Console.ReadLine().ToString();
            string[] listString = inputString.Split(',');
            int[] numbers = new int[listString.Length];
            for (int i = 0; i < listString.Length; i++)
            {
                numbers[i] = Convert.ToInt32(listString[i]);
            }
            int maxNumber = numbers.Max();
            Console.WriteLine(String.Format("maximum number if above list is {0}", maxNumber));
        }
    }
}
