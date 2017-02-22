using UnityEngine;
using System.Collections;

public class flicker : MonoBehaviour {

	public float timeOn = 0.1f;
	public float timeOff = 0.5f;
	private float changeTime = 0f;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > changeTime) {
			GetComponent<Light>().enabled = !GetComponent<Light>().enabled;
			if (GetComponent<Light>().enabled) {
				changeTime = Time.time + timeOn;
			} else {
				changeTime = Time.time + timeOff;
			}
		}
	
	}
}


