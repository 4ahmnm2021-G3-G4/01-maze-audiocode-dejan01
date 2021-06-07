using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour
{
    public GameObject ScaleSack;
    public GameObject Sacklight1;
    public GameObject SackLight2;
    public GameObject SackHeavy;

    void OnTriggerEnter(Collider ScaleSack)
    {
        Debug.Log("Entered");

        if(ScaleSack.gameObject == SackHeavy)
        {
            Debug.Log("Heavy Sack has entered");
        }
    }   
     // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
