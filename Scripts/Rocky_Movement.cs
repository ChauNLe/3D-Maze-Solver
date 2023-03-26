using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocky_Movement : MonoBehaviour
{
    // Start is called before the first frame update

        // Adjust the speed for the application.
    public float speed = 1.0f;

    // The target (cylinder) position.
    public Transform target;


    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        var step =  speed * Time.deltaTime; // calculate distance to move
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);

    }
}
