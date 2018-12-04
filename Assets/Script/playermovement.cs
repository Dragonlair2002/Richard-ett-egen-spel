using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{

    public float moveSpeed = 6f;
    public float JumpSpeed = 12f;

    //GroundChecker är ett annat script som hetter så och varje gång jag skriver groundChecker är menar jag i GroundChecker scriptet.
    public GroundChecker groundCheck;

    //Rigidbody2D är en component som en sprite har och varje gång jag skriver rbody i denna scriptet så menar jag Rigidbody2D.
    private Rigidbody2D rbody;

    // Use this for initialization
    void Start()
    {
        //rbody letar efter en component som heter Rigidbody2D 
        //så varje gång man använder rbody i denna script så menar man Rigidbody2D som spiten har.
        rbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        //rbody har en hastighet som är på vector2 och menas att objekten går i x axeln och y axeln.
        //Och hastigheten på x axeln multiplaceras med movespeed som är en variabel.
        rbody.velocity = new Vector2(Input.GetAxis("Horizontal") * moveSpeed, rbody.velocity.y);

        //Om du trycker ner knappen "jump" (som är space) så ska något hända.
        if (Input.GetButtonDown("Jump"))
        {
            //Om groundcheck.isgrounded är större än 0 så ska något hända.
            if (groundCheck.isgrounded > 0)
            {
                //rbody har en hastighet i Jumpspeed som gör så att kan hoppa upp. Och beroende hur stor Jumpspeed desto högre koppar man.
                rbody.velocity = new Vector2(rbody.velocity.x, JumpSpeed);
            }

            //Om groundCkeck.isgrounded är lika med 1 så ska något hända.
            if (groundCheck.isgrounded == 1)
            {
                //rbody har en hastighet i Jumpspeed som gör så att kan hoppa upp. Och beroende hur stor Jumpspeed desto högre koppar man.
                rbody.velocity = new Vector2(rbody.velocity.x, JumpSpeed);
                //När spelaren har hoppat så ska isgrounded variablen substrahera ett.
                groundCheck.isgrounded--;
            }
        }
    }
}
