using UnityEngine;
using System.Collections;

public class findKey : MonoBehaviour {

    public int keyCheck =0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.tag =="key" )
        {
            keyCheck++;
            if (keyCheck == 3)
            {
                GameObject.Find("door").active = false;
            }
			Destroy (other.gameObject);
        }

    }
}
