﻿using UnityEngine;
using System.Collections;

public class SceneManager : MonoBehaviour
{
	int crystalsLeft;

	// Use this for initialization
	void Start()
	{	crystalsLeft = GameObject.FindGameObjectsWithTag ("Crystal").Length;	}

	public void CrystalPickup()
	{
		crystalsLeft -= 1;
		IsGameOver ();
	}

	void IsGameOver(){
		if (crystalsLeft <= 1) {
			Application.LoadLevel(2);
		}
	}
}
