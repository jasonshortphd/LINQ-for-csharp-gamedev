<Query Kind="Program" />

// ShortGameDesign.com
// Get source from here:  https://github.com/jasonshortphd/LINQ-for-csharp-gamedev
// This came from the Unity3d College
// https://unity3d.college/2017/07/01/linq-unity-developers/
void Main()
{
	// Example Code that doesn't run	
}

// Traditional C# Code
private GameObject GetNearestGameObject(List<GameObject> gameObjectsToConsider)
{
	float smallestDistance = Mathf.Infinity;
	GameObject nearestGameObject;

	foreach (var go in gameObjectsToConsider)
	{
		var distance = Vector3.Distance(transform.position, go.transform.position);
		if (distance < smallestDistance)
		{
			smallestDistance = distance;
			nearestGameObject = go;
		}
	}
	return nearestGameObject;
}

private GameObject GetNearestGameobjectLINQ(List<GameObject> gameObjectsToConsider)
{
	var nearest = gameObjectsToConsider
		.OrderBy(t => Vector3.Distance(transform.position, t.transform.position))
		.FirstOrDefault();
		
	return nearest;
}

