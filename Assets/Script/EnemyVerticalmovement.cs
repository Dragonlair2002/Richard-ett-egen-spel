using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyVerticalmovement : MonoBehaviour
{
    public float SpeedWall;
    public bool Up = true;
    private Rigidbody2D rBody;


    // Use this for initialization
    void Start()
    {
        rBody = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (Up == true)
        {
            rBody.velocity = -(Vector2)transform.right * SpeedWall;
        }
        else
        {
            rBody.velocity = (Vector2)transform.right * SpeedWall;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Om collision.tag är invisibleWall så ska något hända.
        if (collision.tag == "InvisibleWall")
        {
            //När ivisiblewall träffar objektet som är trigger så ändrar den riktning till inte vänster.
            Up = !Up;
        }
    }
}
