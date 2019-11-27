using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class DirectionalArrows : MonoBehaviour
{
	public List<GameObject> wPool;

	public List<GameObject> arrows;

	public GameObject arrowPrefab;
    //public List<Vector3> targetPos;

	// Start is called before the first frame update
	void Start()
	{
		// Just find them once. If they change during play, move to Update
		wPool = GameObject.FindGameObjectsWithTag("Whirlpool").ToList();

		for (int i = 0; i < wPool.Count; i++)
		{
			var item = Instantiate(arrowPrefab, transform.position, Quaternion.identity);
			arrows.Add(item);
            //Vector3 pos = new Vector3(wPool[i].transform.position.x, wPool[i].transform.position.y, this.transform.position.z);
            //targetPos.Add(pos);
			// Make child
			item.transform.parent = transform;
		}
	}

	// Update is called once per frame
	void Update()
	{
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
            for (var counter = 0; counter < wPool.Count; counter++)
            {
                arrows[counter].transform.LookAt(wPool[counter].transform.position);
                //            Material.alpha = 100 / Vector3.Distance(starFish.transform.position, transform.position)
            }
       // }
			
	}
}
