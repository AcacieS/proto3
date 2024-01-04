using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Rigidbody call it of the unity
    private Rigidbody playerRb;
    public float jumpForce = 15.0f;
    //gravity set to 1 is the basic normal gravity
    public float gravityModifier = 2;
    public bool isOnGround = true;

    // Start is called before the first frame update
    void Start()
    {
        //GetComponent inside
        //<> is getting a type.
        playerRb = GetComponent<Rigidbody>();
        //all the physics in unity 
        //Physics.gravity = Physics.gravity * gravityModifier: is *=
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            //AddForce is like Translate
            //4 types of force mode. Normal: apply over time. Impulse: imediate apply 
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            //not longer be on ground.
            isOnGround = false;
        }
    }
    //if player enter collision onto something
    private void OnCollisionEnter(Collision collision)
    {
        isOnGround = true;
    }
}
