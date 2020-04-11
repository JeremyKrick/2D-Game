using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class KillsCounter : MonoBehaviour
{
    public static int killsNumber = 0;
    public TextMeshProUGUI kills;
    // Start is called before the first frame update
    void Start()
    {
        kills.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        kills.SetText("Kills: " + killsNumber);
    }
}
