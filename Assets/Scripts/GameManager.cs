using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public enum Scenes{Main, Game};


public class GameManager : MonoBehaviour
{
	Scenes currScene;

	void Start()
	{
		currScene = Scenes.Main;
	}

	public void StartGame()
	{
		if(currScene == Scenes.Main)
		{
			currScene = Scenes.Game;
			Application.LoadLevel(1);
		}
	}

	public void ReturnToMain()
	{
		if(currScene == Scenes.Game)
		{
			currScene = Scenes.Main;
			Application.LoadLevel(0);
		}
	}

	public void QuitGame()
	{	Application.Quit();	}
}
