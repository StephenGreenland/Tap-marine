using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class DirectionalArrows : MonoBehaviour
{
	public List<WhirlPool> wPool;

	public List<GameObject> arrows;

	public GameObject arrowPrefab;

	// Start is called before the first frame update
	void Start()
	{
		// Just find them once. If they change during play, move to Update
		wPool = FindObjectsOfType<WhirlPool>().ToList();

		for (int i = 0; i < wPool.Count; i++)
		{
			var item = Instantiate(arrowPrefab, transform.position, Quaternion.identity);
			arrows.Add(item);

			// Make child
			item.transform.parent = transform;
		}
	}

	// Update is called once per frame
	void Update()
	{
		for (var counter = 0; counter < wPool.Count; counter++)
		{
			arrows[counter].transform.LookAt(wPool[counter].transform.position);
			//            Material.alpha = 100 / Vector3.Distance(starFish.transform.position, transform.position)

		}
	}
}
