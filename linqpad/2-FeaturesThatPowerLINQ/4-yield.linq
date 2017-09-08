<Query Kind="Program">
  <Namespace>System.Collections.Generic</Namespace>
</Query>

// ShortGameDesign.com
// Get source from here:  https://github.com/jasonshortphd/LINQ-for-csharp-gamedev

// Make sure you have 
// using System.Collections.Generic;
void Main()
{
	var planetIDs = Enumerable.Range(100, 5);

	var results = planetIDs.TripleThis();
	results.Dump();
}

public static class LINQExtensions
{
	public static IEnumerable<T> TripleThis<T>(this IEnumerable<T> input)
	{
		foreach (var p in input)
		{
			yield return p;
			yield return p;
			yield return p;
		}
	}
}

