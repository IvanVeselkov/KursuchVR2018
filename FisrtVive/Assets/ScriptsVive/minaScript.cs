using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class minaScript : MonoBehaviour {

    public GameObject enemy;
    public GameObject mina;
    public bool boom = true;
    public bool stan = false;
    Vector3 minaPosition;

	// Use this for initialization
	void Start () {
        enemy = GameObject.FindGameObjectWithTag("enemy");
        mina = GameObject.Find("mina");
        //mina.active = false;
	}
	
	// Update is called once per frame
	void Update () {
        minaPosition = new Vector3(GameObject.FindGameObjectWithTag("Player").transform.position.x, -1f, GameObject.FindGameObjectWithTag("Player").transform.position.z);
        if ((boom))
        {
            mina.transform.position = minaPosition;
            //mina.transform.position = GameObject.FindGameObjectWithTag("Player").transform.position;
        }
        //minaPosition = new Vector3(GameObject.FindGameObjectWithTag("Player").transform.position.x, 0.9f, GameObject.FindGameObjectWithTag("Player").transform.position.z);
        /*
        if(( Controller.GetPress(SteamVR_Controller.ButtonMask.Grip))&&(boom))
        {
            minaPosition = new Vector3(GameObject.FindGameObjectWithTag("Player").transform.position.x, 0.0f, GameObject.FindGameObjectWithTag("Player").transform.position.z);
            mina.transform.position = minaPosition;
            boom = false;
            //mina.active = true;
        }
        */
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.tag =="enemy")
        {
           // mina.active = false;
            boom = true;
            stan = true;
            GameObject.FindGameObjectWithTag("enemy").GetComponent<enemyMain>().action = false;
        }
    }
}
