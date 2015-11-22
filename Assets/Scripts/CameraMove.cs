using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour
{
	public Transform	player;

	public bool	lerp;
	
	// Use this for initialization
	void Start()
	{
	}

	void Update()
	{
		if(Vector3.Distance(transform.position, player.position) > 2)
		{	lerp = true;	}
		else if(Vector3.Distance(transform.position, player.position) < 1.5)
		{	lerp = false;	}

		if(lerp)
		{	transform.position = Vector3.Lerp(transform.position, player.position, Time.deltaTime * 2);	}
	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{
//		if(Vector3.Distance(transform.position, player.position) > 2)
//		{	transform.position = player.position + 2 * Vector3.Normalize(transform.position - player.position);	}
	}
}
