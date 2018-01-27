using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControl : MonoBehaviour {

    AudioSource audioSource;
    public int startingPitch = 1;

    // Use this for initialization
	void Start () {
        audioSource = GetComponent<AudioSource>();
        audioSource.pitch = startingPitch;
	}
	
	// Update is called once per frame
	void Update () {

        audioSource.pitch = GameObject.Find("Slider").transform.localPosition.x;

	}
}
