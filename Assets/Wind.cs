using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wind : MonoBehaviour
{
    public float yeet;
    private void OnTriggerStay(Collider other)
    {
        other.GetComponent<Rigidbody>().AddForce(Vector3.up * yeet, ForceMode.Acceleration);
        other.GetComponent<Rigidbody>().AddForce(Vector3.back * yeet, ForceMode.Acceleration);
    }
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}