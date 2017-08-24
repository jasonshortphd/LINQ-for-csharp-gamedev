<Query Kind="Program" />

void Main()
{

	GameObject obj = new GameObject { Name = "Player" };

	var targeting = new TargetingProcessor();

	var targetFilters = new TargetFilters();

	// Assign the target handler filter to a method
	Action<GameObject> targetHandler = targetFilters.StrongestEnemy;

	targetHandler += targetFilters.LastEnemy;

	targeting.Process(obj, targetHandler);

	targetHandler = targeting.SpecialCase;
	targeting.Process(obj, targetHandler);

}


public class TargetingProcessor
{
	public void Process(GameObject obj, Action<GameObject> handler)
	{
		handler(obj);
	}

	public void SpecialCase(GameObject obj)
	{
		Console.WriteLine("Special Case Targeting");
	}

}

public class TargetFilters
{
	public void StrongestEnemy(GameObject obj)
	{
		Console.WriteLine("Strongest Target");
	}

	public void LastEnemy(GameObject obj)
	{
		Console.WriteLine("Last Target");
	}

	public void FirstEnemy(GameObject obj)
	{
		Console.WriteLine("First Target");
	}


}



public class GameObject
{
	public string Name;
}
