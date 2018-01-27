using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSpeed : MonoBehaviour {

    ParticleSystem ps;
	// Use this for initialization
	void Start () {
        ps = GetComponent<ParticleSystem>() as ParticleSystem;
	}
	
	// Update is called once per frame
	void Update () {
        ps.playbackSpeed = 2 * Mathf.Abs(GameObject.Find("Slider").transform.localPosition.x);
	}
}
