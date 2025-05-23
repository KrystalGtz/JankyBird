using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    public LogicScript logic;
    // Start is called before the first frame update
    void Start()
    {
        // finds the first instance of a game object with the Logic tag
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        Debug.Log("Triggered by: " + collision.name);
       if (collision.gameObject.layer == 3)
       {
            logic.addScore(1);
       } 
    }
}
