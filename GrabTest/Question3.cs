using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
	public class Question3
	{
		public bool Solution(string bracket)
		{
			Stack<char> stack = new Stack<char>();

			int opening = bracket.Split('(').Length - 1;
			int closing = bracket.Split(')').Length - 1;

			bool output = true;

			if (opening != closing)
			{
				output = false;
			}
			else
			{
				for (int i = 0; i < bracket.Length; i++)
				{
					if (stack.Count == 0)
					{
						stack.Push(bracket[i]);
						stack = Reverse(stack);
					}
					else
					{
						if (stack.Peek() == bracket[i])
						{
							stack.Pop();
						}
						else
						{
							stack.Push(bracket[i]);
							stack = Reverse(stack);
						}
					}
				}

				if (stack.Count == 0)
				{
					output = true;
				}
				else
				{
					for (int i = 0; i < stack.Count; i++)
					{
						if (stack.ElementAt(0) == ')')
							output = false;
						else
						{
							if (stack.ElementAt(i) == '(')
							{
								if (stack.ElementAt(++i) != ')')
								{
									output = false;
									break;
								}
							}
						}
					}
				}
			}


			Console.WriteLine(output);
			return output;

		}

		public static Stack<char> Reverse(Stack<char> stack)
		{
			Stack<char> temp = new Stack<char>();
			while (stack.Count > 0)
			{
				temp.Push(stack.Pop());
			}
			return temp;
		}
	}
}
