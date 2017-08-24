<Query Kind="Program" />

void Main()
{
	var planets = new PlanetRepository().GetPlanets();

	// Step 1
	var planet999 = planets.Single(p => p.PlanetID == 999 );
	planet999.Dump();


	// Step 2 - will crash
//	var missingPlanet = planets.Single(p => p.PlanetID == 888 );
//	missingPlanet.Dump();

	// Step 3
//	var missingPlanet = planets.SingleOrDefault(p => p.PlanetID == 888 );
//	missingPlanet.Dump();

	// Step 4 - First
//	var missingPlanet = planets.First(p => p.PlanetID == 999);
//	missingPlanet.Dump();

	// Step 5 - FirstOrDefault
//	var missingPlanet = planets.FirstOrDefault(p => p.PlanetID == 99);
//	missingPlanet.Dump();
	


}

// Method to use for predicate
static bool IsOwner32(Planet planet)
{
	return planet.Owner == 32;
}


public class PlanetRepository
{
	public IEnumerable<Planet> GetPlanets()
	{
		List<Planet> planets = new List<Planet>();
		for (int i = 0; i < 50; i++)
		{
			planets.Add(new Planet(i, i % 3, i * 2, i % 5, i + 1.1, i + 1.2));
		}

		// Another way to instantiate a planet object
		planets.Add(new Planet() { PlanetID = 999, Owner = 32, NumShips = 32, GrowthRate = 9, X = 23.3, Y = -32.2 });

		return planets;
	}
}

public class Planet
{
	public Planet()
	{

	}

	public Planet(int planetID, int owner, int numShips, int growthRate, double x, double y)
	{
		this.PlanetID = planetID;
		this.Owner = owner;
		this.NumShips = numShips;
		this.GrowthRate = growthRate;
		this.X = x;
		this.Y = y;
	}

	public int PlanetID { get; set; }

	public int Owner { get; set; }

	public int NumShips { get; set; }

	public int GrowthRate { get; set; }

	public double X { get; set; }

	public double Y { get; set; }

	private Planet(Planet _p)
	{
		PlanetID = _p.PlanetID;
		Owner = _p.Owner;
		NumShips = _p.NumShips;
		GrowthRate = _p.GrowthRate;
		X = _p.X;
		Y = _p.Y;
	}

}