<Query Kind="Program" />

// ShortGameDesign.com
// Get source from here:  https://github.com/jasonshortphd/LINQ-for-csharp-gamedev

void Main()
{
	string distance = "123456789";
	
	distance.BytesToGB().Dump();
	
}

// Extension methods for the string class
public static class StringExtensions
{
	private const string sizeInGBFormatter = "{0:0.0}M km";

	public static string BytesToGB(this String str)
	{
		return string.Format(System.Globalization.CultureInfo.CurrentUICulture, sizeInGBFormatter, Double.Parse(str) / 1000 / 1000);
	}

}