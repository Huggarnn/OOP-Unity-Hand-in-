using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Decor : MonoBehaviour
{
    protected int indexOfMaterialToChange = -1;

    [SerializeField] protected Material material;
    protected AudioSource audioSource;

    public void SetColor(Color newColor) //Encapsulation
    {
        if (indexOfMaterialToChange == -1) indexOfMaterialToChange = IndexOfMaterialToChange(); 
        GetComponent<MeshRenderer>().materials[indexOfMaterialToChange].color = newColor; 
    }

    public Color GetColor() //Encapsulation
    {
        if (indexOfMaterialToChange == -1) indexOfMaterialToChange = IndexOfMaterialToChange();
        return GetComponent<MeshRenderer>().materials[indexOfMaterialToChange].color; 
    }

    protected int IndexOfMaterialToChange()
    {
        var r = GetComponent<MeshRenderer>();
        if (r.materials.Length == 1) return 0; 
        for (int i = 0; i < r.materials.Length; i++)
        {
            if (r.materials[i].name.Equals(material.name + " (Instance)"))
            {
                return i;
            }
        }
        return 0; 
    }

    protected void CreateAudioSource()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
    }

    public abstract void Interaction(); //POLYMORPHISM
}
