<Query Kind="Program" />

void Main()
{

	int XP = 0;
	
	XP = PlayerXP.CalcXP( 100 );
	
	Console.WriteLine( XP );
	
}

public class PlayerXP
{
	static int difficulty = 3;
	
	public static int CalcXP( int baseXP )
	{
		
		Func<int, int> multiplier = n => n*difficulty;
		
		
		return multiplier( baseXP );
		
	}

}