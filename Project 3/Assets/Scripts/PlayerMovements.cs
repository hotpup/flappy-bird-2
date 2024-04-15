using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public LogicScript logic;
    bool gameOverTriggered = false;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && !(gameOverTriggered)) {
            myRigidbody.velocity = Vector2.up * 10;
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        logic.gameOverScreen();
        gameOverTriggered = true;
    }
}
