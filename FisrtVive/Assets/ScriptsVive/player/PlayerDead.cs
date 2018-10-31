using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDead : MonoBehaviour {

	public GameObject spawnPosition;
	GameObject player;
	// Use this for initialization
	void Start () {
		player = GameObject.FindWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
		if(player.GetComponent<PlayerHP>().dead)
		{
			player.transform.position=spawnPosition.transform.position;
		}
	}
}
