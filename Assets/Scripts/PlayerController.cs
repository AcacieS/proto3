using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Rigidbody call it of the unity
    private Rigidbody playerRb;
    private Animator playerAnim;
    public float jumpForce = 15.0f;
    //gravity set to 1 is the basic normal gravity
    public float gravityModifier = 2;
    public bool isOnGround = true;
    //default bool is false
    public bool gameOver;

    // Start is called before the first frame update
    void Start()
    {
        //GetComponent inside
        //<> is getting a type.
        playerRb = GetComponent<Rigidbody>();
        playerAnim = GetComponent<Animator>();
        //all the physics in unity 
        //Physics.gravity = Physics.gravity * gravityModifier: is *=
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        //!bool is False
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver)
        {
            //AddForce is like Translate
            //4 types of force mode. Normal: apply over time. Impulse: imediate apply 
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            //not longer be on ground.
            isOnGround = false;
            //SetTrigger("name") as you can see in the name trigger. 
            playerAnim.SetTrigger("Jump_trig");
        }
    }
    //if player enter collision onto something
    private void OnCollisionEnter(Collision collision)
    {
        
        //collision is when collision with something
        //gameObject. the something
        //CompareTag("") can detect if it is this Tag
        if(collision.gameObject.CompareTag("Ground"))
        {
           isOnGround = true; 
        }else if(collision.gameObject.CompareTag("Obstacles"))
        {
            gameOver = true;
            Debug.Log("Game Over");
            //set bool set integer for the type ("name", what equal)
            playerAnim.SetBool("Death_b", true);
            playerAnim.SetInteger("DeathType_int", 1);
        }
    }
}
