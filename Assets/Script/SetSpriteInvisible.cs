using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetSpriteInvisible : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        //Scripten letar efter en component som heter spriterenderer. Sen när man startar spelet så blir spriten onsynlig så att den inte syns i spelet.
        GetComponent<SpriteRenderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
