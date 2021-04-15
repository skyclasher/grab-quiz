using System;
using System.Linq;

namespace ConsoleApp2
{
	public class Question2
	{
		public int Solution(int[] A)
		{
			int days = 30;
			int oneDayTicket = 2;
			int sevenDayTicket = 7;
			int thirtyDayTicket = 25;

			int length = A.Length;

			int cost = 0;
			if (length == days)
			{
				cost = thirtyDayTicket;
			}
			else
			{
				int minDate = A[0];
				int maxDate = A[A.Length - 1];


				for (int i = 0; i < A.Length; i++)
				{
					if (cost >= 25)
					{
						cost = thirtyDayTicket;
						break;
					}

					if (minDate > maxDate)
						break;

					int nextDate = 31;
					int next7Days = minDate + 6;
					int nearest = A.OrderBy(x => Math.Abs((long)x - next7Days)).First();

					int dayDiff = nearest - minDate;

					if (dayDiff >= 3)
					{
						cost += sevenDayTicket;

						int nearIndex = Array.FindIndex(A, x => x == nearest);
						int nextIndex = nearIndex + 1;

						if (nextIndex < A.Length)
						{
							nextDate = A[nextIndex];
							i = nearIndex;
						}
					}
					else
					{
						cost += oneDayTicket;

						int minIndex = Array.FindIndex(A, x => x == minDate);
						nextDate = GetNextDate(A, minIndex);
					}
					minDate = nextDate;
				}

			}
			return cost;
		}

		public int GetNextDate(int[] date, int index)
		{
			if ((index > date.Length - 1) || (index < 0))
				throw new Exception("Invalid index");

			else if (index == date.Length - 1)
				index = 0;

			else
				index++;

			return date[index];
		}
	}

}
