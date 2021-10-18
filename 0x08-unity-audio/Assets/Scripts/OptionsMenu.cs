using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Cinemachine;

public class OptionsMenu : MonoBehaviour
{
    public Toggle yAxisToggle;
    int yAxis;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("yAxis") == 1)
            yAxisToggle.isOn = true;
        else
            yAxisToggle.isOn = false;
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void ApplyPrefs()
    {
        if (yAxisToggle.isOn)
        {
            yAxis = 1;
        }
        else
        {
            yAxis = 0;
        }
        PlayerPrefs.SetInt("yAxis", yAxis);
        SceneManager.LoadScene(PlayerPrefs.GetString("scene"));
    }
}
