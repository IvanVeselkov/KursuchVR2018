using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class exitScript : MonoBehaviour {


    bool onExit = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(onExit)
        {
            if(Input.GetKey("y"))
            {
                SceneManager.LoadScene("S1");
            }
            if(Input.GetKey("n"))
            {
                Application.Quit();
            }
        }
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Player")
        {
            onExit = true;
        }
    }
}
