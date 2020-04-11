using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PrevKills : MonoBehaviour
{
    public static int prevKills = 0;
    public TextMeshProUGUI kills;
    // Start is called before the first frame update
    void Start()
    {
        kills.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        kills.SetText("Previous Kills: " + prevKills);
    }
}
