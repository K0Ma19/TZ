using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
			int[] arr = new int[]{1, 1, 2, 3, 3, 4};

			for (int i = 0; i < arr.Length; i++)
			{
				int currentElementValue = arr[i];

				bool hasEquals = false;

				for (int r = 0; r < arr.Length; r++)
				{
					if (i == r)
					{
						continue;
					}
					if (currentElementValue == arr[r] && i != r)
					{
						hasEquals = true;
					}
				}

				if (!hasEquals)
				{
                    Console.WriteLine(currentElementValue);
				}
			}

		}
    }
    
}
