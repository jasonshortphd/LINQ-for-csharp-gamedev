<Query Kind="Program" />

void Main()
{
	// We start with a Bishop at C6
	// what positions could it reach in ONE move?
	// This is great for path finding in games as well, but always be aware of search space 
	
	// Output needs to include b5, a4, b7, a8

	// This version is MUCH more readable thanks to the methods being used are isolated (and easier to debug)
	var positions =	GetBoardPositions().Where(x => BishopCanMove(x, "c6" ));
		
	positions.Dump();
}


static IEnumerable<string> GetBoardPositions()
{
	return Enumerable.Range('a', 8)
		.SelectMany(x => Enumerable.Range('1', 8), (f, r) => string.Format("{0}{1}", (char)f, (char)r ));
}

static bool BishopCanMove( string startPos, string targetPos)
{
	// Distance from start position to target position (postive only please)
	var dx = Math.Abs( startPos[0] - targetPos[0]);
	var dy = Math.Abs( startPos[1] - targetPos[1]);
	
	// TRUE if they are the same (diagonal movement), and the distance is more than 0 (not a valid move in chess)
	return dx == dy && dx != 0;
}