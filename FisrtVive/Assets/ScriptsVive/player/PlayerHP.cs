using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHP : MonoBehaviour {


	public bool dead;
	public int HP;
	// Use this for initialization
	public bool eat;
	void Start () {
		HP = 100;
		dead = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(eat)
		{
			HP-=51;
		}
		IsDead();
	}

	private void OnTriggerEnter(Collider other) {
		if(other.tag == "enemy")
		{
			eat=true;
		}
	}
	
	void IsDead()
	{
		if(HP<=0)
		{
			dead = true;
		}
	}
}
