using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour {
    float trampoline = 20;
    public Rigidbody actor;
    void Start () {
        actor = GetComponent<Rigidbody>();
    }
    // Use this for initialization
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Trampoline")
        {
            actor.velocity = new Vector3(0, trampoline, trampoline);
        }
    }
}
	
