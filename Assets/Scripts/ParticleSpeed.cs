using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSpeed : MonoBehaviour {

    ParticleSystem ps;
    void Start() { ps = GetComponent<ParticleSystem>() as ParticleSystem; }
    void Update() { ps.playbackSpeed = 2 * Mathf.Abs(GameObject.Find("Slider").transform.localPosition.x); }

}
