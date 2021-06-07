using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scale : MonoBehaviour
{
    public GameObject ScaleSack;
    public GameObject Sacklight1;
    public GameObject SackLight2;
    public GameObject SackHeavy;
    public Text ScaleDisplay;
    /*public Rigidbody SackLight1Rb;
    public Rigidbody SackLight2Rb;
    public Rigidbody SackHeavyRb;*/

    void OnTriggerEnter(Collider ScaleSack)
    {
        Debug.Log("Entered");

        if(ScaleSack.gameObject == SackHeavy)
        {
            Debug.Log("Heavy Sack has entered");
        }

    void OnTriggerStay(Collider ScaleSack)
    {
        ScaleDisplay.text = SackHeavy.GetComponent<Rigidbody>().mass.ToString() + "kg";
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
