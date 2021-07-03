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

    [SerializeField] Color color;

    protected void ChangeSize()
    {
        transform.localScale = Vector3.one * _size;
    }

    protected virtual void ChangeColor()
    {

    }

    protected abstract void Interaction(); //POLYMORPHISM
}
