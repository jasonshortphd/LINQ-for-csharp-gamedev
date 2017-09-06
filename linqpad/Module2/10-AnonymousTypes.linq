<Query Kind="Program" />

// ShortGameDesign.com
// Get source from here:  https://github.com/jasonshortphd/LINQ-for-csharp-gamedev
void Main()
{

	var p1 = new { PlanetName = "Voltan", Title = "Center of Universe", LeaderboardPos = 1 };

	var p2 = new { PlanetName = "Beezle", Title = "Improbbable", LeaderboardPos = 31 };


	// No need to declare a type for this Leaderboard
	// You can create an array of them from same anonymous type!
	var leaderboard = new[] { p1, p2 };

	leaderboard.Dump();


	// Cannot have other fields - all MUST MATCH
	// Following code will fail
/*
	var p3 = new { PlanetName = "Earth", Title = "Mostly Harmless", LastOnline = DateTime.Now };

	var leaderboard2 = new[] { p1, p2, p3 };
	*/


}

