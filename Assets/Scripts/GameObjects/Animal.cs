using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : Decor //INHERITANCE
{
    [SerializeField] AudioClip woof_clip; 

    public override void Interaction()
    {
        audioSource.Play(); 
    }

    // Start is called before the first frame update
    void Start()
    {
        CreateAudioSource();
        audioSource.clip = woof_clip; 
    }

}
