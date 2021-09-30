using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using StarterAssets;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    private bool paused = false;
    private string scene;
    private int sceneIndex;

    void Start()
    {
    }

    void OnEnable()
    {
        Time.timeScale = 1;
        Debug.Log("scene loaded");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            paused = !paused;

            if (paused)
            {
                AcvivateMenu();
            }
            else
            {
                DeactivateMenu();
            }
        }

    }

    public void AcvivateMenu()
    {
        paused = true;
        Time.timeScale = 0f;
        pauseMenu.SetActive(true);
    }

    public void DeactivateMenu()
    {
        paused = false;
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
    }

    public void Options()
    {
        SceneManager.LoadScene("Options");
    }

    public void Resume()
    {
        paused = false;
        Debug.Log("Resume");
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

    public void Menu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
