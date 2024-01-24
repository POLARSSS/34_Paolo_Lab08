using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalculatorScript : MonoBehaviour
{
    public Text DebugText;
    public InputField txtAmount;
    float SGDAmount;
    public Toggle USD;
    public Toggle JPY;
    public Toggle RM;
    public Toggle EUR;
    public Toggle KWR;
    public Toggle TWD;

    float value;
    public Text Convertedvalue;
    float valueamount;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void conversion()
    {
        SGDAmount = float.Parse(txtAmount.text);

        if (USD.GetComponent<Toggle>().gameObject == true)
        {
            value = SGDAmount * 0.74f;
            Convertedvalue.text = "$" + value.ToString() + " USD";
        }

        if (JPY.GetComponent<Toggle>().isOn == true)
        {
            value = SGDAmount * 110.5f;
            Convertedvalue.text = "$" + value.ToString() + " JPY";
        }

        if (RM.GetComponent<Toggle>().isOn == true)
        {
            value = SGDAmount * 3.08f;
            Convertedvalue.text = '$' + value.ToString() + " RM";
        }

        if (EUR.GetComponent<Toggle>().isOn == true)
        {
            value = SGDAmount * 0.63f;
            Convertedvalue.text = '$' + value.ToString() + " EUR";
        }

        if (KWR.GetComponent<Toggle>().isOn == true)
        {
            value = SGDAmount * 881.54f;
            Convertedvalue.text = '$' + value.ToString() + " KWR";
        }

        if (TWD.GetComponent<Toggle>().isOn == true)
        {
            value = SGDAmount * 20.73f;
            Convertedvalue.text = '$' + value.ToString() + " TWD";
        }


        if ((USD.GetComponent<Toggle>().gameObject == true) && (JPY.GetComponent<Toggle>().isOn == true) && (RM.GetComponent<Toggle>().isOn == true) && (EUR.GetComponent<Toggle>().isOn == true) && (KWR.GetComponent<Toggle>().isOn == true) && (TWD.GetComponent<Toggle>().isOn == true))
        {
            Convertedvalue.text = "Invalid Input";
        }
       
    }
    public void clear()
    {
        Convertedvalue.text = "";
        txtAmount.text = "";
        JPY.GetComponent<Toggle>().isOn = false;
        USD.GetComponent<Toggle>().isOn = false;
        RM.GetComponent<Toggle>().isOn = false;
        EUR.GetComponent<Toggle>().isOn = false;
        KWR.GetComponent<Toggle>().isOn = false;
        TWD.GetComponent<Toggle>().isOn = false;
    }
    
}
