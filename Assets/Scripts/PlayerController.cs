using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Rigidbody call it of the unity
    private Rigidbody playerRb;
    public float jumpForce = 10.0f

    // Start is called before the first frame update
    void Start()
    {
        //GetComponent inside
        //<> is getting a type.
        playerRb = GetComponent<Rigidbody>();
        //all the physics in unity
        Physics.gravity *=
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //AddForce is like Translate
            //4 types of force mode. Normal: apply over time. Impulse: imediate apply 
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
