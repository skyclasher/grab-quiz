namespace ConsoleApp2
{
	public class Question5
	{
		public void Solution()
		{
			//two array involve
			int[] array = { 1, 2, 3, 4, 5, 6 };
			int[] array2 = new int[6];

			int counter = 0;

			for (int i = 5; i >= 0; i--)
			{
				array2[counter] = array[i];
				++counter;

			}
			Output(array);
			Output(array2);

			//one array - for loop
			array = new int[] { 1, 2, 3, 4, 5, 6 };

			for (int i = 0; i < array.Length / 2; i++)
			{
				int tmp = array[i];
				array[i] = array[array.Length - i - 1];
				array[array.Length - i - 1] = tmp;
			}
			Output(array);

			//one array - while loop
			array = new int[] { 1, 2, 3, 4, 5, 6 };

			int k = 0;
			int l = array.Length - 1;
			while (k < l)
			{
				var temp = array[k];
				array[k] = array[l];
				array[l] = temp;
				k++;
				l--;
			}
			Output(array);
		}

		private void Output(int[] arr)
		{
			foreach (int i in arr)
			{
				System.Console.Write("{0} ", i);
			}
			System.Console.WriteLine();
		}
	}
}
