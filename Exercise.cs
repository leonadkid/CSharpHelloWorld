using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

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

        public static void FacebookFriendsLike()
        {
            var namesList = new List<string>();
            var enterName = "";
            do
            {
                Console.WriteLine("Please enter the name that like the post: ");
                enterName = Console.ReadLine();
                if (!enterName.Equals(""))
                    namesList.Add(enterName);
            }
            while (!enterName.Equals(""));
            
            if (namesList.Count == 1)
            {
                Console.WriteLine(String.Format("{0} likes your post.", namesList[0]));
            }
            else if (namesList.Count == 2)
            {
                Console.WriteLine(String.Format("{0} and {1} like your post.", namesList[0], namesList[1]));
            }
            else if (namesList.Count > 2)
            {
                Console.WriteLine(String.Format("{0}, {1} and {2} others like your post.", namesList[0], namesList[1], namesList.Count - 2));
            }
        }

        public static void ReversedName()
        {
            Console.WriteLine("Please enter your name:");
            String name = Console.ReadLine();
            var characters = new char[name.Length];
            for (var i = 0; i < name.Length; i++)
            {
                characters[i] = name[i];
            }
            Array.Reverse(characters);
            string reversedName = new string(characters);
            Console.WriteLine(String.Format("The Reversed name is: {0}", reversedName));
        }

        public static void DistinctNumber()
        {   
            var enterednumber = 0;
            var numbers = new List<int>();
            while (numbers.Count < 5)
            {
                var flag = false;
                Console.WriteLine("Please enter a number:");
                enterednumber = Convert.ToInt32(Console.ReadLine());
                {
                    for (var i = 0; i < numbers.Count ; i++)
                    {
                        if (enterednumber == numbers[i])
                        {
                            flag = true;
                            Console.WriteLine(String.Format("Error !!!\n{0} already in the list, please retry", enterednumber));
                        }
                    }
                    if (flag == false)
                    {
                        numbers.Add(enterednumber);
                    }
                }
            }
            numbers.Sort();
            Console.WriteLine("Sort 5 numbers:");
            foreach(var number in numbers)
                Console.WriteLine(number);
        }

        public static void ShowDistincNumbers()
        {
            var enteredNumber = "";
            var numbers = new List<int>();
            var flag = false;
            while (!enteredNumber.ToLower().Equals("quit"))
            {
                Console.WriteLine("Please enter a number:");
                enteredNumber = Console.ReadLine();
                if (!enteredNumber.ToLower().Equals("quit"))
                {
                    for (var i = 0; i < numbers.Count; i++)
                    {
                        if (Convert.ToInt32(enteredNumber) == numbers[i])
                        {
                            flag = true;
                        }
                    }
                    if (flag == false)
                    {
                        numbers.Add(Convert.ToInt32(enteredNumber));
                    }
                }                          
            }
            Console.WriteLine("List numbers you just entered:");
            foreach (var number in numbers)
                Console.WriteLine(number);
        }

        public static void SplitStringByComma()
        {
            Console.WriteLine("Please enter list of string separate by comma");
            String enteredNumber = Console.ReadLine();
            var listString = enteredNumber.Split(',').ToList();
            if (listString.Count >= 5)
            {
                foreach (var number in listString)
                {
                    Console.WriteLine(number);
                }
            }
            else
            {
                Console.WriteLine("Invalid List");
            }
        }

        public static string ConsecutiveNumbers(List<String> listStr)
        {
            String summary;
            bool flag = true;
            if (listStr.Count == 1)
            {
                summary = "Consecutive";
                return summary;
            }
                
            if (listStr.Count > 1)
            {
                int diffNumber = Convert.ToInt32(listStr[1].Trim()) - Convert.ToInt32(listStr[0].Trim());
                for (int i = 1; i < listStr.Count; i++)
                {
                    if (Convert.ToInt32(listStr[i].Trim()) != Convert.ToInt32(listStr[i-1].Trim()) + diffNumber)
                    {
                        flag = false;
                        break;
                    }                    
                    
                }
            }
            if (flag)
            {
                summary = "Consecutive";
            }
            else
            {
                summary = "Not Consecutive";
            }
            return summary;
        }

        public static bool CheckIfDuplicate(List<String> listStr)
        {
            bool isDuplicate = false;
            if (listStr.Count == 1)
                return true;
            else if (listStr.Count > 1)
            {
                listStr.Sort();
                for (var i = 1; i < listStr.Count; i++)
                {
                    if (listStr[i] == listStr[i - 1])
                    {
                        isDuplicate = true;
                        break;
                    }
                }
            }
            return isDuplicate;
        }

        public static bool CheckValidTime(String str)
        {
            bool flag = true;
            var listStr = str.Split(":");
            if (listStr.Count() != 2)
            {
                flag = false;
                return flag;

            }
            if (listStr[0].ToArray().Count() != 2 || listStr[1].ToArray().Count() != 2 )
            {
                flag = false;
                return flag;

            }
            if (Convert.ToInt32(listStr[0]) < 0 && Convert.ToInt32(listStr[0]) >= 24)
            {
                flag = false;
                return flag;

            }
            if (Convert.ToInt32(listStr[1]) < 0 && Convert.ToInt32(listStr[1]) >= 60)
            {
                flag = false;
                return flag;
            }
            return flag;
        }

        public static String ReturnPascalCase(String str)
        {
            var listStr = str.Split(" ").ToList();
            var pascalCaseList = new List<String>();
            var finalString = "";
            for (int i = 0; i < listStr.Count; i++)
            {
                var innerList = listStr[i].ToList();
                var finalStr = innerList[0].ToString().ToUpper() + listStr[i].Substring(1).ToLower();
                pascalCaseList.Add(finalStr);
            }
            foreach (var pascalCase in pascalCaseList)
            {
                finalString += pascalCase;
            }
            return finalString;
        }

        public static int CountVowels(String str)
        {
            var listChars = str.ToArray();
            var listVowels = new char[] { 'a', 'e', 'o', 'u', 'i' };
            int counter = 0;
            for (int i = 0; i < listChars.Count(); i++)
            {
                for (int j = 0; j < listVowels.Count(); j++)
                {
                    if (listChars[i] == listVowels[j])
                    {
                        counter++;
                        break;
                    }
                }
            }
            return counter;
        }

        public static int CountNumberOfWords(string path)
        {
            var contentFile = File.ReadAllText(path);
            var words = contentFile.Split(" ").ToList();
            if (contentFile.Trim().Equals(""))
                return 0;
            return words.Count;
        }

        public static string GetLongestWords(string path)
        {
            var numChars = 0;
            var longestWords = "";
            var words = File.ReadAllText(path).Split(" ").ToList();
            foreach (var word in words)
            {
                var chars = word.ToArray();
                if (chars.Count() > numChars)
                {
                    numChars = chars.Count();
                    longestWords = word;
                }
            }
            return longestWords;
        }
    }
}
