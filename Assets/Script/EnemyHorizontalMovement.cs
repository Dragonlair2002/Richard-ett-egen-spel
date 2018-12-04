using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHorizontalMovement : MonoBehaviour
{
    public float speedGround = 2f;
    //Bool menas att det kan antingen vara på eller av.
    public bool left = true;

    private Rigidbody2D rbody;
    
    
    // Use this for initialization
    void Start()
    {
        //rbody letar efter en component som heter Rigidbody2D 
        //så varje gång man använder rbody i denna script så menar man Rigidbody2D som spiten har.
        rbody = GetComponent<Rigidbody2D>();
    }



    //FixedUpdate betyder varje fixed framerate frame. Man brukar anävnda det till Rigidbody.
    private void FixedUpdate()
    {
        //Om vänster (left) blir true så ska något hända.
        if (left == true)
        {
            //rbody får en hastighet för att röra sig år vänster.
            rbody.velocity = -(Vector2)transform.right * speedGround;
            //När objekten ska röra sig åt vänster så vrider den sig i 180 grader om den innan rörde sig åt höger, annars inte.
            transform.localScale = new Vector3(1, 1, 1);
        }
        //När den inte blir true så ska något annat hända. 
        else
        {
            //rbody får en hastighet för att röra sig åt höger.
            rbody.velocity = (Vector2)transform.right * speedGround;
            //När objekten ska röra sig åt höger så vrider den sig 180 om den innan rörde sig åt vänster, annars inte
            transform.localScale = new Vector3(-1, 1, 1);
        }




    }
    //När objektet går in i en triggerkollider som är fäst vid det här objektet (Funkar bara i 2D).
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Om collision.tag är invisibleWall så ska något hända.
        if (collision.tag == "InvisibleWall")
        {
            //När ivisiblewall träffar objektet som är trigger så ändrar den riktning till inte vänster.
            left = !left;
        }
    }

}
