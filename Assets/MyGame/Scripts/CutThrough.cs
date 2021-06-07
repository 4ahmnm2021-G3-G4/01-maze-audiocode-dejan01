using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutThrough : MonoBehaviour
{
    public GameObject Knife;
    public GameObject HeavySack;
    public GameObject Peanuts;


    private void OnTriggerEnter(Collider Knife) {
        Debug.Log("Cut through");
        HeavySack.GetComponent<MeshRenderer>().enabled = false;
        Peanuts.GetComponent<Rigidbody>().useGravity = true;
    }
}
