using System;
using System.Linq;

namespace ConsoleApp2
{
	public class Class1
	{
		public int solution(int[] A)
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

					int next7Days = minDate + 6;

					int nearest = A.OrderBy(x => Math.Abs((long)x - next7Days)).First();

					int nearIndex = Array.FindIndex(A, x => x == nearest);
					int nextIndex = nearIndex + 1;
					int nextDate = 31;

					if (nextIndex < A.Length)
					{
						nextDate = A[nextIndex];
						i = nearIndex;
					}

					int dayDiff = nearest - minDate;

					if (dayDiff >= 3)
					{
						cost += sevenDayTicket;
					}
					else
					{
						cost += oneDayTicket;
					}
					minDate = nextDate;
				}

			}
			return cost;
		}
	}

}
