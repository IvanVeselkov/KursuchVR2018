using UnityEngine;
using System.Collections;

public class timer : MonoBehaviour {

    public float _timer;
	// Use this for initialization
	void Start () {
        _timer = 5f;
	}
	
	// Update is called once per frame
    void Update()
    {
        if ((_timer > 0)&&(GameObject.Find("Player").GetComponent<PlayerHP>().eat))
        {
            _timer -= Time.deltaTime;
        }
        if ((_timer < 0)&&(GameObject.Find("Player").GetComponent<PlayerHP>().eat))
        {
            GameObject.Find("Player").GetComponent<PlayerHP>().eat = false;
            _timer = 5f;
        }

        if ((_timer > 0)&&(GameObject.Find("mina").GetComponent<BombScript>().stan))
        {
            _timer -= Time.deltaTime;
        }
        if ((_timer < 0) && (GameObject.Find("mina").GetComponent<BombScript>().stan))
        {
            _timer = 5f;
            GameObject.Find("mina").GetComponent<BombScript>().stan = false;
        }
    }
}
