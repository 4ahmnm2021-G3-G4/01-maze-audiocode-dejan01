using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scale : MonoBehaviour
{
    public GameObject ScaleSack;
    public GameObject SackLight2;
    public GameObject Sack10;
    public GameObject SackLight7;
    public GameObject SackLight5;
    public GameObject SackLight8;
    public Text ScaleDisplay;
    public GameObject ScaleScript;


    

    public void OnTriggerEnter(Collider ScaleSack)
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

        if(ScaleSack.gameObject == Sack10)
        {
            Debug.Log("Sack 10kg has entered");
            ScaleDisplay.text = Sack10.GetComponent<Rigidbody>().mass.ToString() + "kg";
            ScaleScript.SetActive(true);
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
