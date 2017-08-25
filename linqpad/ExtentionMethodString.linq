<Query Kind="Program" />

// ShortGameDesign.com
// Get source from here:  https://github.com/jasonshortphd/LINQ-for-csharp-gamedev
void Main()
{
	string longText = "Commander, our ships are under attack and we may not survive.";
	
	var shortenedText = longText.Shorten(6);

	shortenedText.Dump();
	
}


// Extension methods for the string class
public static class StringExtensions
{
	public static string Shorten(this String str, int numberOfWords)
	{
		if( numberOfWords <= 0 )
			return string.Empty;
			
		var words = str.Split(' ');
		
		if( words.Length <= numberOfWords)
			return str;
		
		return string.Join(" ", words.Take(numberOfWords)) + "...";
	}

}