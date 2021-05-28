using System;
using System.Collections.Generic;

class Trial_class {

	static public void Main()
	{

		LinkedList<String> my_list = new LinkedList<String>();

		my_list.AddLast("Tesla");
		my_list.AddLast("BMW");
		my_list.AddLast("Audi");
		my_list.AddLast("Bugati");
		my_list.AddLast("RangeRover");
		my_list.AddLast("Toyota");

		Console.WriteLine("Best Cars of Year 2021:");

		foreach(string str in my_list)
		{
			Console.WriteLine(str);
		}
	}
}
