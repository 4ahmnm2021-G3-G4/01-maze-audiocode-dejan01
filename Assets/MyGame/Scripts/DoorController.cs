using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    Animator _doorAnim;
    private void OnTriggerEnter(Collider other) {
        _doorAnim.SetBool("IsOpening", true);
        Debug.Log("Collision detected");
    }

    private void OnTriggerExit(Collider other) {
        _doorAnim.SetBool("IsOpening", false);
        Destroy(this.gameObject);
        Debug.Log("Destroyed self");
    }

    void Start()
    {
        _doorAnim = this.transform.parent.GetComponent<Animator>();
    }

    void Update()
    {
        
    }
}
