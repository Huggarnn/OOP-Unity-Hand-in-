using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thing : Decor //INHERITANCE
{
    public override void Interaction()
    {
        
    }

    private void Start()
    {
        gameObject.tag = "Thing"; 
    }

}
