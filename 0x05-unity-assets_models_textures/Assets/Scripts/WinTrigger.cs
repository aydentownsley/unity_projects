using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinTrigger : MonoBehaviour
{
    public GameObject player;
    public Timer time_script;
    public Text timetext;

    void OnTriggerEnter()
    {
        // Time.timeScale = 0;
        timetext.fontSize = 60;
        timetext.color = Color.green;
        time_script.enabled = false;
    }
}
