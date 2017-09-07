<Query Kind="Program">
  <Namespace>System.Collections.Generic</Namespace>
  <Namespace>System.Linq</Namespace>
</Query>

// ShortGameDesign.com
// Get source from here:  https://github.com/jasonshortphd/LINQ-for-csharp-gamedev
void Main()
{
	
	var intArray = new MyGenericArray<int>(5);

	for (int i = 0; i < 5; i++)
	{
		intArray.setItem(i, i);
	}

	intArray.Display();
	
	var namesArray = new MyGenericArray<string>(5);
	
	namesArray.setItem(0, "Mickey");
	namesArray.setItem(1, "Donald");
	namesArray.setItem(2, "Goofy");
	namesArray.setItem(3, "Minnie");
	namesArray.setItem(4, "Daisy");
	
	namesArray.Display();
}

public class MyGenericArray<T>
{
	private T[] array;
	public MyGenericArray(int size)
	{
		array = new T[size];
	}

	public T getItem(int index)
	{
		return array[index];
	}

	public void setItem(int index, T value)
	{
		array[index] = value;
	}
	
	public void Display()
	{
		array.Dump();
	}
}