using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plant : Decor //INHERITANCE
{
    [SerializeField] AudioClip rustle_clip;
    public override void Interaction() //POLYMORPHISM
    {
        audioSource.Play(); 
    }

    private void Start()
    {
        CreateAudioSource();
        audioSource.clip = rustle_clip; 
    }

}
