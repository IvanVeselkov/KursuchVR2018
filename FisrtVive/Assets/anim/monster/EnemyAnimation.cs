using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimation : MonoBehaviour {

	
    static Animator anim;
    public GameObject enemy;
    public GameObject player;

    GameObject bomb;
    Vector3 lastPosition;
    bool fingPlayer;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        lastPosition = enemy.transform.position;
        player = GameObject.FindWithTag("Player");
        bomb = GameObject.FindWithTag("weapon");
	}
	
	// Update is called once per frame
	void Update () {
        //running   
        if(isMoving())
        {
            anim.SetBool("isAttack",false);
            anim.SetBool("isRunning",true);
        }
		else
		{
			anim.SetBool("isRunning",false);
		}

        if(player.GetComponent<PlayerHP>().eat)
        {
            anim.SetBool("isRunning",false);
            anim.SetBool("isAttack",true);
        }

        if(bomb.GetComponent<BombScript>().stan)
        {
            anim.SetBool("isRunning",false);
            anim.SetBool("isAgony",true);
        }
    }

    bool isMoving()
    {
        if ( enemy.transform.position != lastPosition)
        {
            lastPosition = enemy.transform.position;
            return true;
        }
        else
            return false;
    }
    
}
