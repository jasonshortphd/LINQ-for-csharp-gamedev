<Query Kind="Statements" />


var DaysTillXmas = (new DateTime( DateTime.Today.Year, 12, 25 ) - DateTime.Today).TotalDays;

DaysTillXmas.Dump();


