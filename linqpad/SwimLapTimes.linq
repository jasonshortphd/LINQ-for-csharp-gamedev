<Query Kind="Statements" />


// Lap times

var lapTimes = "00:45,01:32,02:18,03:01,03:44,04:31,05:19,06:01,06:47,07:35";


// Ugly and confusing, and you have to iterate list TWICE
("00:00," + lapTimes)
	.Split(',')
	.Zip(lapTimes.Split(','),
		(s, f) => new
		{
			Start = TimeSpan.Parse("00:" + s),
			Finish = TimeSpan.Parse("00:" + f)
		})
		.Select(x => x.Finish-x.Start )
	.Dump();


// MoreLINQ NuGet allows for this
/*
("00:00," + lapTimes)
	.Split(',')
.Select(x => TimeSpan.Parse("00:" +x))
.Pairwise((a,b) => b - a)
.Dump();

*/