<Query Kind="Program" />

void Main()
{
	var planets = new PlanetRepository().GetPlanets();

	// LINQ extension methods
	// more powerful because more extension methods are available
	var weakPlanets = planets.Where(p => p.NumShips < 10)
							.OrderBy(p => p.Owner)
							.Select( p => p );
							//.Select(p => p.PlanetID);

	weakPlanets.Dump();

	
	// LINQ query operators
	var otherWeakPlanets = from p in planets
							where p.NumShips < 10
							orderby p.Owner
							select p;

	otherWeakPlanets.Dump();

//	foreach (var p in weakPlanets)
//	{
//		Console.WriteLine("Planet {0} - {1} Ships ",  p.PlanetID, p.NumShips);
//	}
	

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