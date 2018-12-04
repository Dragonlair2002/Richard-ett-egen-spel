using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreText : MonoBehaviour
{
    //private menas att det bara visas i scriptet. TextMeshproUGUI är en component som jag sen ändrar den till en variabel som är text.
    private TextMeshProUGUI text;

    void Start()
    {
        //variablen text letar efter en component som heter TextMeshProUGUI.
        text = GetComponent<TextMeshProUGUI>();
    }


    void Update()
    {
        //Dette gör så att du får text i skärmen, alltså texten, föremolet förjer skärmen. Och detta gör att varje mynt du tar så står det på skärmen poängen. Och det vissas också på detta viss, 000, 001, 002...
        text.text = string.Format("Score: {0:0000}", Coins.Score);
    }
}
