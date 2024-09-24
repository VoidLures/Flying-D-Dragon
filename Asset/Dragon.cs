using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragon : MonoBehaviour
{

    public Rigidbody2D rigid_body;
    public float flystrength;
    public logicscript logic;
    public bool alive = true;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logicscript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && alive == true)
        { 
            rigid_body.velocity = Vector2.up*flystrength;
        }

        if (transform.position.y < -5 || transform.position.y > 5)
        {
            alive = false;
            logic.gameoverscreen();
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        alive = false;
        logic.gameoverscreen();
    }
}
