using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using HelloWorld.Math;

namespace HelloWorld
{
	public enum ShippingMethod
	{
		RegularAirMall = 1,
		RegisterAirMall = 2,
		Express = 3
	}
	class Program
	{
		static void Main(string[] args)
		{
			String path = @"D:\@ME\CSharpFundamentals\HelloWorld\Hello Words.txt";
            Console.WriteLine("Longest words: " + Exercises.Exercises.GetLongestWords(path));
		}
	}
}
