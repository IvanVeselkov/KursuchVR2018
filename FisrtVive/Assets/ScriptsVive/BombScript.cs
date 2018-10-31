using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombScript : MonoBehaviour {

	GameObject bomb;
	public bool stan;
	void Start () {
		bomb = GameObject.FindWithTag("weapon");
		stan = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter(Collider other) {
		if(other.tag=="enemy")
		{
			stan = true;
		}
	}
}
