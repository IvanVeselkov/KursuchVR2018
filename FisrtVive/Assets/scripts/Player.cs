using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]

public class Player : MonoBehaviour {
    public Rigidbody Mybode;
    public float Speed;
    private Vector3 Movement;
    static Animator anim;
    float Forward;
	// Use this for initialization
	void Start () 
    {
        Mybode = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () 
    {
        //if (Forward != 0)
        //{
        //    anim.SetBool("isRunning", true);
        //}
        //else
        //{
        //    anim.SetBool("isRunning", false);
        //}
	}

    void FixedUpdate()
    {
        float Rigth = Input.GetAxisRaw("Horizontal");
        Forward = Input.GetAxisRaw("Vertical");

        Movement.Set(Forward, 0f, Rigth);

        Mybode.AddForce(transform.forward * Forward * Speed, ForceMode.Impulse);
        Mybode.AddForce(transform.right*Rigth*Speed, ForceMode.Impulse);
    }
}
