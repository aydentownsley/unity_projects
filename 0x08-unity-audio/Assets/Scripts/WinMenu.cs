using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMenu : MonoBehaviour
{
    private string scene;
    private int sceneIndex;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Next()
    {
        scene = PlayerPrefs.GetString("scene");
        sceneIndex = int.Parse(scene.Substring(5, 2));
        if (sceneIndex <= 2)
        {
            sceneIndex += 1;
            SceneManager.LoadScene("Level0" + sceneIndex);
        }
        else
        {
            sceneIndex = 1;
            SceneManager.LoadScene("MainMenu");
        }

    }
}
