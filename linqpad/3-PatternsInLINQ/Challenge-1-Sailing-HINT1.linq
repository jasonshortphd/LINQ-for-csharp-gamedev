<Query Kind="Expression" />

// Sailing Rules: Add together the best FOUR result scores
// http://www.sailing.org/rankings/match/method_of_calculation.php
// http://www.worldsailingywc.org/results/2016_auckland_newzealand.php
// RK(GBR) Places
// 6,9,7,10,12,26,5,7,9

// Scores
"50,20,40,10,8,0,60,40,20"
.Split(',')  // Note that this will leave us with STRINGS, not integers!
