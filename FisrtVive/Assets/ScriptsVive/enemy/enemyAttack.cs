using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemyAttack : MonoBehaviour {

    NavMeshAgent navEn;
    GameObject player;
	// Use this for initialization
	void Start () {
        navEn = GetComponent<NavMeshAgent>();
        navEn.enabled = true;
        player = GameObject.FindWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
		if(GameObject.FindWithTag("enemy").GetComponent<enemyMain>().action)
        {
            navEn.SetDestination(player.transform.position);
        }
	}
}
