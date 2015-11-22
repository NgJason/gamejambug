using UnityEngine;
using System.Collections;

public class CrystalDestroy : MonoBehaviour
{
	public SpriteRenderer	spriteRenderer;
	
	public float	timeStart;
	public float	burstSpeed;
	public bool		pickedUp;
	
	// Use this for initialization
	void Start ()
	{
		spriteRenderer = GetComponent<SpriteRenderer>();
		pickedUp = false;
		burstSpeed = 3;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(pickedUp)
		{
			float timePassed = Time.time - timeStart;
			if(timePassed >= .5)
			{
				Destroy(gameObject);
			}
			else
			{
				float size = 2 + burstSpeed * Mathf.Pow(timePassed, 1f/3f);
				transform.localScale = new Vector3(size, size, 0f);
				Color color = spriteRenderer.color;
				color.a = 1 - (timePassed*2);
				spriteRenderer.color = color;
			}
		}
	}
}
