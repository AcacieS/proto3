using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private Vector3 posStart;
    private float repeatWidth;
    // Start is called before the first frame update
    void Start()
    {
        posStart = transform.position;
        //GetComponent<>() is to get a component from the object remember
        repeatWidth = GetComponent<BoxCollider>().size.x/2;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < posStart.x - repeatWidth)
        {
            transform.position = posStart;
        }
    }
}
