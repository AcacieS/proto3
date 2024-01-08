using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 10.0f;
    // Start is called before the first frame update
    //private you can't reference to it from other scripts.
    private PlayerController playerControllerScript;
    private float leftBound = -15;
    void Start()
    {
        //GameObject the Object
        //Find("")find a tag I think and get there
        //GetComponent<>() of there no "" inside
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(playerControllerScript.gameOver == false)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime); 
        }
        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacles"))
        {
            Destroy(gameObject);
        }
        
    }
}
