using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tech : Decor //INHERITANCE
{
    [SerializeField] Light light;
    [SerializeField] Material mat;

    bool isOn = false; 

    protected override void Interaction()
    {
        throw new System.NotImplementedException();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
