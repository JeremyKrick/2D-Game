using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Increment : MonoBehaviour
{
    public int num = 0;
    public int numperclick = 1;
    public TextMeshProUGUI outputText;
    
    public void XpClicked()
    {
        num += numperclick;
        outputText.SetText("XP: " + num);
    }
    public void HpClicked()
    {
        num += numperclick;
        outputText.SetText("HP: " + num);
    }
    public void ArmorClicked()
    {
        num += numperclick;
        outputText.SetText("ARMOR CLASS: " + num);
    }
    public void SpeedClicked()
    {
        num += numperclick;
        outputText.SetText("SPEED: " + num);
    }
    public void ListClicked()
    {

    }
}