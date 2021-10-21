 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    // private CharacterController controller;
    // private Vector3 playerVelocity;
    // private bool groundedPlayer;
    // public float playerSpeed = 10.0f;
    // public float jumpHeight = 1.0f;
    // public float gravityValue = -9.81f;
    public Vector3 startposition = new Vector3(0, 25, 0);
    private bool yAxis = false;
    public GameObject player;
    public GameObject Freelook;

    private void Start()
    {
        PlayerPrefs.SetString("scene", SceneManager.GetActiveScene().name);
        if (PlayerPrefs.GetInt("yAxis") == 1)
            yAxis = true;
        else
            yAxis = false;

        GameObject.Find("Freelook").GetComponent<CinemachineFreeLook>().m_YAxis.m_InvertInput = yAxis;
    }

    void FixedUpdate()
    {

        if (transform.position.y < -25)
        {
            Freelook.GetComponent<CinemachineFreeLook>().enabled = false;
            gameObject.GetComponent<CharacterController>().enabled = false;
            transform.position = startposition;
            Freelook.GetComponent<CinemachineFreeLook>().enabled = true;
            gameObject.GetComponent<CharacterController>().enabled = true;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("moving"))
        {
            player.transform.SetParent(other.gameObject.transform, true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("moving"))
        {
            player.transform.SetParent(null);
        }
    }

}
