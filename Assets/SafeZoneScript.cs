using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class SafeZoneScript : MonoBehaviour
{
    //how to reference other scripts
    public ScoreKeeper scoreKeeper;
    public BoxCollider2D scoreCollider;

    // Start is called before the first frame update
    void Start()
    {
        scoreKeeper = GameObject.FindGameObjectWithTag("Logic").GetComponent<ScoreKeeper>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        scoreKeeper.increaseScore();
    }


}
