using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CrystalPickup : MonoBehaviour
{
	public SceneManager	manager;
	
	// Use this for initialization
	void Start ()
	{
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
	
	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Crystal")
		{
			Debug.Log("hit");
			manager.CrystalPickup();
//			other.GetComponent<AudioSource>().Play();
			CrystalDestroy survivorScript = other.GetComponentInChildren<CrystalDestroy>();
			survivorScript.pickedUp = true;
			survivorScript.timeStart = Time.time;
			other.GetComponent<BoxCollider>().enabled = false;
		}
	}
}
