using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tech : Decor //INHERITANCE
{
    [SerializeField] Light light;
    [SerializeField] Material isOnMat;
    private MeshRenderer renderer;

    Material[] matsOn = new Material[2];
    Material[] matsOff = new Material[2];

    [SerializeField] AudioClip click_clip; 

    bool isOn = false; 

    public override void Interaction() //POLYMORPHISM
    {
        Debug.Log("Tech");
        if (isOn)
        {
            isOn = false;
            light.gameObject.SetActive(false);
            renderer.materials = matsOn;
            Debug.Log(renderer.materials[1]);
        }
        else if (!isOn)
        {
            isOn = true;
            light.gameObject.SetActive(true);
            renderer.materials = matsOff; 
            Debug.Log(renderer.materials[1]);      
        }

        audioSource.Play();
    }

    void Start()
    {
        Init(); //ABSTRACTION
    }

    private void Init()
    {
        renderer = GetComponent<MeshRenderer>();
        matsOn[0] = renderer.materials[0];
        matsOn[1] = material;
        matsOff[0] = renderer.materials[0];
        matsOff[1] = isOnMat;

        CreateAudioSource(); 
        if (click_clip != null) audioSource.clip = click_clip;
    }
}
