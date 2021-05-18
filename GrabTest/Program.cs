using System;

namespace ConsoleApp2
{
	class Program
	{
		static void Main(string[] args)
		{
			//Question 1 get fee for parking
			string E = "10:00";
			string L = "12:10";

			Question1 question1 = new Question1();
			Console.WriteLine(question1.Solution(E, L));

			//Question 2 get cheapest ticket price
			Question2 question2 = new Question2();

			//int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };
			//int[] array = { 1, 2, 3, 4, 5, 6, 7, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };
			//int[] array = { 1, 2, 3, 4, 5, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };
			int[] array = { 1, 2, 20, 21, 23, 24, 29, 30 };


			Console.WriteLine(question2.Solution(array));


			// Given a string of '(',')', write a function to validate a string based on these rules:
			// 
			// 1. Any opening brackets '(' must have a corresponding closing brackets ')'.
			// 2. Any closing brackets ')' must have a corresponding opening brackets '('.
			// 3. Opening brackets '(' must go before the closing brackets ')'.
			//
			Question3 question3 = new Question3();


			string bracket = "(()(()()))";   // True
											 //string bracket = "((())())";     // True
											 //string bracket = "(())";         // True
											 //string bracket = "()((()))()()"; // True
											 //string bracket = "(()";          // False
											 //string bracket = "()((()))())";  // False
											 //string bracket = ")";            // False

			Console.WriteLine(question3.Solution(bracket));

			//Revers array
			Question5 question5 = new Question5();
			question5.Solution();

			Console.ReadLine();


		}
	}
}
