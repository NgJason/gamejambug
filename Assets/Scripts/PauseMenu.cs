using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour {

    public Canvas PauseCanvas;

	// Use this for initialization
	void Start () {
        PauseCanvas.enabled = false;
        //Cursor.lockState = CursorLockMode.Locked;
        //Cursor.visible = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Time.timeScale = 0;
            //Cursor.lockState = CursorLockMode.None;
            //Cursor.visible = true;
            PauseCanvas.enabled = true;
        }
	}

    public void Resume()
    {
        Time.timeScale = 1;
        //Cursor.lockState = CursorLockMode.Locked;
        //Cursor.visible = false;
        PauseCanvas.enabled = false;
    }

    public void MainMenu()
    {
        Time.timeScale = 1;
        Application.LoadLevel(0);
    }

    public void Restart()
    {
        Time.timeScale = 1;
        Application.LoadLevel(1);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
