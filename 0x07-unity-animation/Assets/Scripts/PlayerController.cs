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

    private void Start()
    {
        PlayerPrefs.SetString("scene", SceneManager.GetActiveScene().name);
        if (PlayerPrefs.GetInt("yAxis") == 1)
            yAxis = true;
        else
            yAxis = false;

        GameObject.Find("Freelook").GetComponent<CinemachineFreeLook>().m_YAxis.m_InvertInput = yAxis;
        // controller = gameObject.AddComponent<CharacterController>();
        // controller.skinWidth = 0.001f;
    }

    void FixedUpdate()
    {
        // groundedPlayer = controller.isGrounded;
        // if (groundedPlayer && playerVelocity.y < 0)
        //     playerVelocity.y = 0f;

        // Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        // controller.Move(move * Time.deltaTime * playerSpeed);

        // if (move != Vector3.zero)
        // {
        //     gameObject.transform.forward = move;
        // }

        // // Changes the height position of the player..
        // if (Input.GetButton("Jump") && groundedPlayer)
        // {
        //     playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
        // }

        // playerVelocity.y += gravityValue * Time.deltaTime;
        // controller.Move(playerVelocity * Time.deltaTime);

        if (transform.position.y < -25)
        {
            gameObject.GetComponent<CharacterController>().enabled = false;
            transform.position = startposition;
            gameObject.GetComponent<CharacterController>().enabled = true;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision");
        Debug.Log(other.gameObject.name);
        if (other.gameObject.CompareTag("moving"))
        {
            Debug.Log("moving");
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
