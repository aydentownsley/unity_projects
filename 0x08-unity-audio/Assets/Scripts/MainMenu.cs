using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void LoadLevel01()
    {
        SceneManager.LoadScene("Level01");
    }

    public void LoadLevel02()
    {
        SceneManager.LoadScene("Level02");
    }

    public void LoadLevel03()
    {
        SceneManager.LoadScene("Level03");
    }

    public void LoadOptions()
    {
        SceneManager.LoadScene("Options");
    }

    public void Exit()
    {
        Debug.Log("Exited");
        Application.Quit();
    }
}
