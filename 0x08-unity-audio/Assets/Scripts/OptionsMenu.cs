using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Cinemachine;
using UnityEngine.Audio;

public class OptionsMenu : MonoBehaviour
{
    public Toggle yAxisToggle;
    public AudioMixer Mixer;
    public Slider BGM;
    public Slider SFX;
    float BGM_level;
    float SFX_level;
    int yAxis;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("yAxis") == 1)
            yAxisToggle.isOn = true;
        else
            yAxisToggle.isOn = false;

        SFX.value = PlayerPrefs.GetFloat("SFX_Volume");
        BGM.value = PlayerPrefs.GetFloat("BGM_Volume");
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

        SFX_level = SFX.value;
        BGM_level = BGM.value;
        PlayerPrefs.SetInt("yAxis", yAxis);
        PlayerPrefs.SetFloat("SFX_Volume", SFX_level);
        PlayerPrefs.SetFloat("BGM_Volume", BGM_level);

        SceneManager.LoadScene(PlayerPrefs.GetString("scene"));
    }

    public void SetSFXLevel(float slider_value)
    {
        Mixer.SetFloat("SFX_Run", Mathf.Log10(slider_value) * 20 - 20);
        Mixer.SetFloat("SFX_Land", Mathf.Log10(slider_value) * 20 + 2);
        Mixer.SetFloat("SFX_Amb", Mathf.Log10(slider_value) * 20 + 5);
        // SFX_level = slider_value;
    }

    public void SetBGMLevel(float slider_value)
    {
        Mixer.SetFloat("BGM", Mathf.Log10(slider_value) * 20);
        // BGM_level = slider_value;
    }
}
