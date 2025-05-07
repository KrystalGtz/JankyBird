using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    public GameObject pipe;
    private float spawnTime = 5;
    private float timer = 0;
    private float heightOffset = 10;
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame 
    void Update()
    {
        
        if (timer < spawnTime) 
        {
            timer += Time.deltaTime;
        } 
        else
        {
         spawnPipe();
         timer = 0;
        }
    }

    void spawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        // game object, position, rotation
        //Vecotr3(spawner position,random range to change spawn height)
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
