using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemyPatrule : MonoBehaviour
{
 
    public GameObject point;
    NavMeshAgent nav;
    static public string[] points =
        { "Point1", "Point2", "Point3", "Point4", "Point5", "Point6",
        "Point7", "Point8", "Point9", "Point10", "Point11", "Point12",
        "Point13" , "Point14", "Point15", "Point16", "Point17", "Point18",
        "Point19", "Point20", "Point21", "Point22", "Point23"};
    public int s;

    // Use this for initialization
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
        s = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.FindWithTag("enemy").GetComponent<enemyMain>().action==false)
        {
            point = GameObject.Find(points[s]);
            nav.SetDestination(point.transform.position);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Point")
        {
            s = (int)Mathf.Round(Random.Range(0F, 22F));
        }
    }
}
