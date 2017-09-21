<Query Kind="Statements" />

// ShortGameDesign.com
// Get source from here:  https://github.com/jasonshortphd/LINQ-for-csharp-gamedev
var players = new[] {

	new { GamerTag = "OneOhm", Name = "Jason" },
	new { GamerTag = "Boxer", Name = string.Empty },
	new { GamerTag = "Lowenbrau", Name = "Daniel" },

};

foreach (var p in players.Where(p => string.IsNullOrEmpty(p.Name) ))
{
	Console.WriteLine("{0} doesn't have a name", p.GamerTag);
}

