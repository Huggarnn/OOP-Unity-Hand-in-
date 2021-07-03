using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Decor : MonoBehaviour
{
    protected const float MINSIZE = 0.1f;
    protected const float MAXSIZE = 3.0f; 
    private float _size;
    [SerializeField] public float Size //ENCAPSULATION
    {
        get { return _size; }
        set 
        {
            if (value < MINSIZE)
            {
                Debug.LogWarning("size cannot be smaller than minimum size");
                _size = MINSIZE;
            }
            else if (value > MAXSIZE)
            {
                Debug.LogWarning("size cannot be bigger than maximum size");
                _size = MAXSIZE;
            }
            else _size = value;            
        }
    }

    [SerializeField] protected Material material;


    protected void SetSize(float size)
    {
        Size = size; 
        transform.localScale = Vector3.one * Size;
    }

    public float GetSize()
    {
        Size = transform.localScale.magnitude;
        return Size; 
    }

    public void SetColor(Color newColor)
    {
        material.color = newColor;
        if(GetComponent<MeshRenderer>().materials[1] != null)
            GetComponent<MeshRenderer>().materials[1].color = newColor; 
        else GetComponent<MeshRenderer>().materials[0].color = newColor;
    }

    public Color GetColor()
    {
        return material.color; 
    }

    public void GetData()
    {

    }

    public abstract void Interaction(); //POLYMORPHISM
}
