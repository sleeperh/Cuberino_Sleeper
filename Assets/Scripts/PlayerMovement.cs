using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    private float forwardForce  = 8000f;
    public float sidewaysForce = 500f;
    public Scrollbar scrollbar;
    private float moveSpeed;

    private void Start()
    {
        scrollbar.onValueChanged.AddListener((float val) => ScrollbarCallback(val));
    }

    void ScrollbarCallback(float value)
    {
        moveSpeed = value * forwardForce;
    }

    // FixedUpdate is preferred when manipulating physics. 
    void FixedUpdate()
    {
        rb.AddForce(0, 0, moveSpeed * Time.deltaTime); // Add a force called moveSpeed on the z-axis
        if (Input.GetKey("d")) 
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }

    
}
