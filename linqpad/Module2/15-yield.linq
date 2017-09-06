<Query Kind="Program" />

// ShortGameDesign.com
// Get source from here:  https://github.com/jasonshortphd/LINQ-for-csharp-gamedev
void Main()
{
	var planetIDs = Enumerable.Range(100, 5);
	var results = DoublePlanets( planetIDs );
	results.Dump();
}

IEnumerable DoublePlanets(IEnumerable planets)
{
	foreach (var p in planets)
	{
		yield return p;
		yield return p;
	}
}