using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RollDice : MonoBehaviour
{
    public int numberDice = 5;
    public int sidesDice = 6;
    public int modifier = 2;
    public int total = 0;
    public int[] dieRoll = new int[5];
    public TextMeshProUGUI outputText;

    int i, first, second, third;
   
    Color colorTop = new Color(0.3764706f, 0.85882354f, 1, 1);
    Color colorBottom = new Color(0, 0.7764706f, 1, 1);

    public void RolltheDice()
    {
        int counter = numberDice;
        //For each die, roll the die and store the value in dieRoll[].
        while (counter > 0)
        {
            int randomNum = Random.Range(1, sidesDice);
            dieRoll[counter-1] = randomNum;
            counter = (counter - 1);
        }
        //Get top 3 die roll values.
        third = first = second = 000;
        for (i = 0; i < dieRoll.Length; i++)
        {
            if (dieRoll[i] > first)
            {
                third = second;
                second = first;
                first = dieRoll[i];
            }
            else if (dieRoll[i] > second)
            {
                third = second;
                second = dieRoll[i];
            }
            else if (dieRoll[i] > third)
                third = dieRoll[i];
        }
        total = first + second + third + modifier;

        outputText.GetComponent<TextMeshProUGUI>().text = "";
        outputText.enableVertexGradient = true;
        outputText.colorGradient = new VertexGradient(colorTop, colorTop, colorBottom, colorBottom);
        outputText.text += "+" + total;
        Debug.Log(outputText.text);
    }
}
