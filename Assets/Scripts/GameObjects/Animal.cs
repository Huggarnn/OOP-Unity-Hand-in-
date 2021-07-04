using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : Decor //INHERITANCE
{
    [SerializeField] AudioClip woof_clip; 

    public override void Interaction() //POLYMORPHISM
    {
        audioSource.Play(); 
    }

    void Start()
    {
        CreateAudioSource();
        audioSource.clip = woof_clip; 
    }

}
