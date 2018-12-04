using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    //Static betydet att det är på alla script.
    public static int Score;
    public int amount = 1;
    //Float menas att det är ett tal och att det kan ha 7 decimaler.
    private float Coinspin = 180;
    //Void Start menas vad som ska hända först när man startar scenen.
    void Start()
    {

    }

    //Void Update menas i varje frame så går den igenom scriptet om det ska hända något i scenen.
    void Update()
    {
        //Att myntet/coin roterar runt y axeln.
        transform.Rotate(0, Coinspin * Time.deltaTime, 0);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Om objekten som har taggen player så ska något hända.
        if (collision.tag == "Player")
        {
            //När player träffar coin så adderas amount som coin.score har som är ett. Så du får ett poäng för varje mynt.
            Coins.Score += amount;
            //Efter att du har taggit ditt mynt så försvinner den coin.
            Destroy(gameObject);
        }


    }
}
