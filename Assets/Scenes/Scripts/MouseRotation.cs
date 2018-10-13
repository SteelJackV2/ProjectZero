using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseRotation : MonoBehaviour {


    /*float rotSpeed = 20;

    void OnMouseDrag()
    {
        float rotX = Input.GetAxis("Mouse X") * rotSpeed * Mathf.Deg2Rad;
        float rotY = Input.GetAxis("Mouse Y") * rotSpeed * Mathf.Deg2Rad;

        transform.RotateAround(Vector3.up, -rotX);
        //transform.RotateAround(Vector3.right, rotY);
    }



    Vector2 mouseLook;
    Vector2 smoothV;
    public float senstitivity = 5.0f;
    public float smoothing = 2.0f;
    private Rigidbody rb;
    public float speed;
    Vector3 m_EulerAngleVelocity;



    GameObject character;

    void Start () {
        character = this.transform.parent.gameObject;
        rb = GetComponent<Rigidbody>();
        m_EulerAngleVelocity = new Vector3(0, Input.GetAxis("Mouse Y"), 0);


    }

    void Update () {
        var md = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
            
        md = Vector2.Scale(md, new Vector2(senstitivity*smoothing, senstitivity*smoothing));
        smoothV.x = Mathf.Lerp(smoothV.x, md.y, 1f / smoothing);
        smoothV.y = Mathf.Lerp(smoothV.y, md.x, 1f / smoothing);
        mouseLook += smoothV;

        //transform.localRotation = Quaternion.AngleAxis(-mouseLook.y, Vector3.up);
        //rb.transform.localRotation = Quaternion.AngleAxis(mouseLook.x, character.transform.up);
        //rb.MoveRotation = Quaternion.AngleAxis(-mouseLook.y, Vector3.up);
        //rb.rotation = Quaternion.AngleAxis(-mouseLook.y, Vector3.up);




    }

    private void FixedUpdate(){
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        Quaternion deltaRotation = Quaternion.Euler(m_EulerAngleVelocity * Time.deltaTime);
        rb.MoveRotation(rb.rotation * deltaRotation);
        rb.AddForce(movement * speed);
    }*/
}
