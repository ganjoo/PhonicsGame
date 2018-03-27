using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour {

    public AudioClip SoundPlay;
    public float Volume;
    AudioSource audio;
    public bool alreadyPlayed = false;

	// Use this for initialization
	void Start () {
        audio = GetComponent <AudioSource> () ;
		
	}
	
	// Update is called once per frame
	void onTriggerEnter () {
        if (!alreadyPlayed)
        {
            audio.PlayOneShot(SoundPlay, Volume);
            alreadyPlayed = true;
        }
		
	}
}
