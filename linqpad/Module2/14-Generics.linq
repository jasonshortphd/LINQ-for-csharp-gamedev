<Query Kind="Program" />

// ShortGameDesign.com
// Get source from here:  https://github.com/jasonshortphd/LINQ-for-csharp-gamedev
void Main()
{
	Leaderboard<int> leaderInts = new Leaderboard<int>();

	foreach (var pid in Enumerable.Range(1, 10))
	{
		leaderInts.AddPlayer(pid);
	}
	
	if( leaderInts.PlayerExists(4) )
		Console.WriteLine("Found");
	
	Leaderboard<Player> players = new Leaderboard<Player>();

	players.AddPlayer(new Player { ID = 1, Name = "Jason" } );
	
}

// I don't know what types this will be used with...
public class Leaderboard<T>
{
	List<T> entries = new List<T>();
	
	public void AddPlayer( T player )
	{
		entries.Add( player );
	}
	
	public bool PlayerExists( T player )
	{
		return entries.Contains(player);
	}

}

public class Player
{
	public int ID;
	public string Name;
}