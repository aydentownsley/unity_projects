using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;
    // private Vector3 offsetX;
    // private Vector3 offsetY;
    Vector2 rotation = Vector2.zero;
    public float speed = 3;
    // Start is called before the first frame update
    void Start()
    {
        // offsetX = transform.position;
        // offsetY = transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.RotateAround(player.position, Vector3.up, Input.GetAxis("Mouse X") * speed);
        transform.LookAt(player.position);
    }
}
