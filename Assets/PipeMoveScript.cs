using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PipeMoveScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public  float moveSpeed = 8;
    public float deadZone = -150;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        if(transform.position.x < deadZone){
            //  debug.Log("Pipe deleted");
            Destroy(gameObject);
        }
    }
}
