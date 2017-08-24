<Query Kind="Statements" />

// We start with a Bishop at C6
// what positions could it reach in ONE move?
// This is great for path finding in games as well, but always be aware of search space 

// Output needs to include b5, a4, b7, a8

var currentPosition = new { File = 'c', Rank = '6' };

// Generate a chess board using Enumerable.Range
var positions = Enumerable.Range('a', 8)
	.SelectMany(x => Enumerable.Range('1', 8 ), (f,r) => new {File = (char)f, Rank = (char)r })
	// Bishops can move where the row & col distance are both equal (meaning a diagonal)
	.Where( x => Math.Abs( x.File - currentPosition.File) == Math.Abs( x.Rank - currentPosition.Rank))
	.Where(x => x.File != currentPosition.File )
	.Select( x => string.Format("{0}{1}", x.File, x.Rank));
	
positions.Dump();

