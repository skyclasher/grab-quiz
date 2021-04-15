using System;

namespace ConsoleApp2
{
	public class Question1
	{
		public int Solution(string E, string L)
		{
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
			return fee;
		}
	}
}
