using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Transform player;
    public float speed = 0;
    
    private float mouseSensitivity = 1000f;
    public Transform playerBody;
    public Transform playerEyes;

    private float mouseX;
    private float mouseY;
    
    void Start()
    {
        player = GetComponent<Transform>();
        Cursor.visible = false;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            player.transform.position -= transform.right * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            player.transform.position += transform.right * Time.deltaTime * speed;
        }
        
        if (Input.GetKey(KeyCode.W))
        {
            player.transform.position += transform.forward * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            player.transform.position -= transform.forward * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.L))
        {
            Cursor.visible = true;
        }
        
        mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        playerBody.Rotate(Vector3.up * mouseX);
        playerEyes.Rotate(Vector3.left * mouseY);
    }
}