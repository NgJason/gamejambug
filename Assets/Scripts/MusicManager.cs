using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour {

	public AudioClip NewMusic; //Pick an audio track to play.
    public AudioSource go;

    void Awake()
    {
        //GameObject go = GameObject.Find("Game Music"); //Finds the game object called Game Music, if it goes by a different name, change this.
        go.clip = NewMusic; //Replaces the old audio with the new one set in the inspector.
        go.Play(); //Plays the audio.
    } 
}
