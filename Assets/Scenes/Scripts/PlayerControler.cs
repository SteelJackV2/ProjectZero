using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour {

    public float speed;
    public Transform camTransform = Camera.main.transform;
    float rotation;
    public Vector3 movement;
    public GameObject head;
    public Transform bbhead;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;

    }

    private void Update()
    {
        head.transform.position = transform.position;
    }

    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        float mouse = Input.GetAxis("Mouse X");


        movement = new Vector3(moveHorizontal, 0f, moveVertical);
        movement = camTransform.TransformDirection(movement);
        float r = camTransform.rotation.y;
        head.transform.Rotate(Vector3.forward, mouse);

        rb.AddForce(movement*speed);

        if (Input.GetKeyDown("escape"))
            Cursor.lockState = CursorLockMode.None;
    }

}
