using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : Decor //INHERITANCE
{
    AudioClip woof_clip; 

    public override void Interaction()
    {
        Debug.Log("Animal"); 
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
