using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour {
    public bool notswung;
    public GameObject box;

    void start()
    {
        box.SetActive(true);
    }
    private void OnTriggerEnter(Collider other)
    {
        box.SetActive(false);
    }
}
