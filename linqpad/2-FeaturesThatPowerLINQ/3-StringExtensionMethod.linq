<Query Kind="Program" />

// ShortGameDesign.com
// Get source from here:  https://github.com/jasonshortphd/LINQ-for-csharp-gamedev
void Main()
{
	string remoteInfo = "I have a great idea for a way to shorten a news post to a summary";
	
	var shorter = remoteInfo.Shorten(5);
	
	shorter.Dump();
	
}


// Extension methods for the string class
public static class StringExtensions
{
	public static string Shorten(this String str, int numberOfWords)
	{
		if (numberOfWords <= 0)
			return string.Empty;

		var words = str.Split(' ');

		if (words.Length <= numberOfWords)
			return str;

		return string.Join(" ", words.Take(numberOfWords)) + "...";
	}

}