using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scale : MonoBehaviour
{
    public GameObject ScaleSack;
    public GameObject SackLight2;
    public GameObject SackLight3;
    public GameObject SackLight7;
    public GameObject SackLight5;
    public GameObject SackLight8;
    public Text ScaleDisplay;

    void OnTriggerEnter(Collider ScaleSack)
    {
        //Debug.Log("Entered");

        if(ScaleSack.gameObject == SackLight8)
        {
            Debug.Log("Sack Light 8 has entered");
            ScaleDisplay.text = SackLight8.GetComponent<Rigidbody>().mass.ToString() + "kg";
        }

        if(ScaleSack.gameObject == SackLight2)
        {
            Debug.Log("Sack Light 2 has entered");
            ScaleDisplay.text = SackLight2.GetComponent<Rigidbody>().mass.ToString() + "kg";
        }

        if(ScaleSack.gameObject == SackLight3)
        {
            Debug.Log("Sack Light 3 has entered");
            ScaleDisplay.text = SackLight3.GetComponent<Rigidbody>().mass.ToString() + "kg";
        }

        if(ScaleSack.gameObject == SackLight7)
        {
            Debug.Log("Sack Light 7 has entered");
            ScaleDisplay.text = SackLight7.GetComponent<Rigidbody>().mass.ToString() + "kg";
        }

        if(ScaleSack.gameObject == SackLight5)
        {
            Debug.Log("Sack Light5 has entered");
            ScaleDisplay.text = SackLight5.GetComponent<Rigidbody>().mass.ToString() + "kg";
        }
    }

    void OnTriggerExit(Collider ScaleSack)
    {
        ScaleDisplay.text = "";
    }

      
}
