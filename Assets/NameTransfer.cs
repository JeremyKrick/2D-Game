using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NameTransfer : MonoBehaviour
{
    public string theName;
    public GameObject inputField;
    public TextMeshProUGUI textDisplay;
    

    public void StoreName()
    {
        theName = inputField.GetComponent<Text>().text;
        textDisplay.GetComponent<TextMeshProUGUI>().text = theName.ToUpper();
        
    }
}