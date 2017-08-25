<Query Kind="Program" />

// ShortGameDesign.com
// Get source from here:  https://github.com/jasonshortphd/LINQ-for-csharp-gamedev
// Original idea from Mark Heath - http://www.markheath.net/post/lunchtime-linq-challenge-answers	
void Main()
{
	// We start with a Bishop at C6
	// what positions could it reach in ONE move?
	// This is great for path finding in games as well, but always be aware of search space 

	// Output needs to include b5, a4, b7, a8

	var currentPosition = new { File = 'c', Rank = '6' };

	// Query expression syntax makes this different, but also very readable
	// It is NOT just for database access
	// Simplifies anonymous objects
	// And is custom made to really help pipelines needing a SelectMany stage
	
	var positions =	
	
		from row in Enumerable.Range('a', 8)
		from col in Enumerable.Range('1', 8)
		let dx = Math.Abs( row - currentPosition.File )
		let dy = Math.Abs( col - currentPosition.Rank )
		where dx == dy && dx != 0
		select String.Format("{0}{1}", (char)row, (char)col);
		
	positions.Dump();
}