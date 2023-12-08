using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D birdBody;
    public float flapStregnth;

    // Start is called before the first frame update, meaning it runs at the beginning of the game and only runs once
    void Start()
    {
        
    }

    // Update is called once per frame, so it's runs constantly as long as the game is running
    void Update()
    {
        
        
        if(Input.GetKeyDown(KeyCode.Space))
        {
            birdBody.velocity = Vector2.up * flapStregnth;
        }
    }
}
