using System;

public class Insertion_of_ele_in_array {

	static public void Main()
	{

		int n = 10;                     
		int[] arr = new int[n];        // n is size of array
		int i;

		for (i = 0; i < n; i++)
			arr[i] = i + 1;

		for (i = 0; i < n; i++)
			Console.Write(arr[i] + " ");
		Console.WriteLine();

        // Now we have to insert ele x in the array(arr) at a specific position
		int x = 123;
		int pos = 5;

		// create a new array of size n+1
		int[] newarr = new int[n + 1];

		for (i = 0; i < n + 1; i++) {   // logic is we have to insert elements in new array as per old array until position (n-1)
			if (i < pos - 1)            // then insert value of x in postion n and then again insert element form old array to new array
				newarr[i] = arr[i];     
			else if (i == pos - 1)
				newarr[i] = x;
			else
				newarr[i] = arr[i - 1];  // with new array position i and old array with (i-1)
		}

		for (i = 0; i < n + 1; i++)
			Console.Write(newarr[i] + " ");
		Console.WriteLine();
	}
}
