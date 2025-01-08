using UnityEngine;
using System.Collections;
using System.Collections.Generic;



public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnInterval = 10;
    public float heightOffset = 10;

    private float timer = 0;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnInterval)
        {
            SpawnPipe();
            timer = 0;
        }
    }

    void SpawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        float randomHeight = Random.Range(lowestPoint, highestPoint);

        Vector3 spawnPosition = new Vector3(transform.position.x, randomHeight, 0);
        Instantiate(pipe, spawnPosition, Quaternion.identity);
    }
}













// public class PipeSpawnScript : MonoBehaviour
// {
//     // Start is called once before the first execution of Update after the MonoBehaviour is created
//     public GameObject pipe;
//     public float spawnRate = 1;
//     public float timer = 0;
//     public float heightOffset = 10;
    

//     void Start()
//     {
//         spawnPipe();
//     }

//     // Update is called once per frame
//     void Update()
//     {
//         if(timer < spawnRate){
//             timer += Time.deltaTime;
//         }
//         else{
//             spawnPipe();
//             timer = 0;

//         }
        
//     }

//     void spawnPipe(){
        
//         float lowestPoint = transform.position.y - heightOffset;
//         float highestPoint = transform.position.y + heightOffset;

//         Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint,highestPoint),0), transform.rotation);
//     }
// }
