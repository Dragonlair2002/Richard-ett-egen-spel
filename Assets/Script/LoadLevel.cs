using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadLevel : MonoBehaviour
{
    //public menas att det vissas i unity och kan ändras i unity och inte bara i scriptet, int menas att bara hela nummer,
    //minimumScoreNeeded är en variabel och 0:an är variabelns värde.
    public int minimumScoreNeeded;
    //String menas att det är text, sceneToLoad är variablen och "SammpleScene" är vad min scene hetter och varje gång jag skriver
    //sceneToLoad i denna script så menar jag Samplescene.
    public string sceneToLoad = "Level2";

    //När objektet går in i en triggerkollider som är fäst vid det här objektet (Funkar bara i 2D).
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Om objekten har en tag som är player och poänger ska vara mer eller lika med så ska något hända.
        if (collision.tag == "Player" && Coins.Score >= minimumScoreNeeded)
        {
            //När bannan laddas om så ska man börja med 0 poäng .
            Coins.Score = 0;
            //Bannan laddas om.
            SceneManager.LoadScene(sceneToLoad);
        }

    }


}
