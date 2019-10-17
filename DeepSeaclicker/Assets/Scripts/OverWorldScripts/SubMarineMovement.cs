using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubMarineMovement : MonoBehaviour
{
	private Vector2 targetPos;
	private Vector2 currentPos;

	public float speed;

	// Start is called before the first frame update
	void Start()
    {
		currentPos = this.transform.position;
		targetPos =  transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

		targetPos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0f));

		Debug.Log(targetPos);

		if (Input.GetMouseButton(0))
		{
			Debug.Log("CLICKED");

			transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

			this.transform.LookAt(targetPos);
		}
    }
}
