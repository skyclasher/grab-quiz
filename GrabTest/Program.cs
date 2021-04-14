using System;

namespace ConsoleApp2
{
	class Program
	{
		static void Main(string[] args)
		{
			//Question 1 get fee for parking

			string E = "10:00";
			string L = "12:30";

			TimeSpan startTime = TimeSpan.Parse(E);
			TimeSpan endTime = TimeSpan.Parse(L);

			int entranceFee = 2;
			int firstHour = 3;
			int subSequence = 4;

			TimeSpan hours = endTime - startTime;

			int fee = 0;
			if (hours > new TimeSpan(1, 0, 0))
			{
				int subHours = (hours - new TimeSpan(1, 0, 0)).Hours;
				if (hours.Minutes > 0)
				{
					++subHours;
				}
				fee = entranceFee + firstHour + (subHours * subSequence);
			}
			else
			{
				fee = entranceFee + firstHour;
			}


			//Question 2 get cheapest ticket price
			Class1 class1 = new Class1();

			int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };
			//int[] array = { 1, 2, 3, 4, 5, 6, 7, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };
			//int[] array = { 1, 2, 3, 4, 5, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };


			Console.WriteLine(class1.solution(array));
			Console.ReadLine();




		}
	}
}
