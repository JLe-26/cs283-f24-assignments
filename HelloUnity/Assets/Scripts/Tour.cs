using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tour : MonoBehaviour
{

    public Transform[] targets = new Transform[4]; // all POIs, four gameObjects
    public float speed = 1;
    public float duration; // time between each camera transition

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < targets.Length; i++)
        {
            if(Input.GetKey(KeyCode.N))
            {
                transform.position = Vector3.Lerp(transform.position, targets[i].position, speed * Time.deltaTime);
                // Add rotation using Slerp
            }
        }
    }
}
