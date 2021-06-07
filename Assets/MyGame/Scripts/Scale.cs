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

    void OnTriggerEnter(Collider ScaleSack)
    {
        Debug.Log("Entered");

        if(ScaleSack.gameObject == SackHeavy)
        {
            Debug.Log("Heavy Sack has entered");
            ScaleDisplay.text = SackHeavy.GetComponent<Rigidbody>().mass.ToString() + "kg";
        }

        if(ScaleSack.gameObject == Sacklight1)
        {
            Debug.Log("Heavy Sack has entered");
            ScaleDisplay.text = Sacklight1.GetComponent<Rigidbody>().mass.ToString() + "kg";
        }

        if(ScaleSack.gameObject == SackLight2)
        {
            Debug.Log("Heavy Sack has entered");
            ScaleDisplay.text = SackLight2.GetComponent<Rigidbody>().mass.ToString() + "kg";
        }
    }

    void OnTriggerExit(Collider ScaleSack)
    {
        ScaleDisplay.text = "";
    }

      
}
