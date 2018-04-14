using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiyokoGenerator : MonoBehaviour {
	[SerializeField] GameObject obj;
	[SerializeField] float interval = 3.0f;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("SpawnObj", 0.1f, interval);
	}
	
	void SpawnObj () {
		Instantiate (obj, transform.position, transform.rotation);		
	}
}
