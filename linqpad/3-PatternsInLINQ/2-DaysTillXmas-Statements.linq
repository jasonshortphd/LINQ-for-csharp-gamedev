<Query Kind="Statements" />

// ShortGameDesign.com
// Get source from here:  https://github.com/jasonshortphd/LINQ-for-csharp-gamedev

var DaysTillXmas = (new DateTime( DateTime.Today.Year, 12, 25 ) - DateTime.Today).TotalDays;

DaysTillXmas.Dump();