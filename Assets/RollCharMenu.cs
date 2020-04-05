using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RollCharMenu : MonoBehaviour
{
    public TMP_InputField tmpInputField;

    public void Start()
    {
        string input = tmpInputField.text;
        SubmitName(input);
    }

    public void SubmitName(string text)
    {
        Debug.Log("Output String: " + text);
    }


}
