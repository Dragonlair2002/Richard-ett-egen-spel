using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChecker : MonoBehaviour
{
    //public menas att det visas i unity. int menas att det kan vara vilken siffra som hellst och har knan ha till 7 decemaler. Och isgrounded är variablen.
    public int isgrounded;

    //När objektet går in i en triggerkollider som är fäst vid det här objektet (Funkar bara i 2D).
    private void OnTriggerEnter2D(Collider2D other)
    {
        //Om variablen isgrounded är lika med 1 så ska något hända.
        if (isgrounded == 1)
        {
            //isgrounded adderar nummer ett.
            isgrounded++;
        }
        
        //Om variablen isgrounded är lika med 0 så ska något hända.
        if (isgrounded == 0)
        {
            //Variablen isgrounded adderar nummer två.
            isgrounded += 2;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
            //isgrounded substraherar nummer ett.
            isgrounded--;
        
    }
}
