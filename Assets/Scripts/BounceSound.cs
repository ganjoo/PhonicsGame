using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceSound : MonoBehaviour {

    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    
}
