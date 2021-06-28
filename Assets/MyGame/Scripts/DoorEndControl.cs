using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorEndControl : MonoBehaviour
{

    Animator _doorEnd;
    public AudioSource doorSoundEnd;

    void OnTriggerEnter(Collider other)
    {
        _doorEnd.SetBool("isOpening", true);
        doorSoundEnd.Play(0);
    }
    void Start()
    {
        _doorEnd = this.transform.parent.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
