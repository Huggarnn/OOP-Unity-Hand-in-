using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager<T> : MonoBehaviour where T : MonoBehaviour  
{
    private static T instance; 
    public static T Instance //ENCAPSULATION
    {
        get { return instance; }
        set
        {
            if(null == instance)
            {
                instance = value;
                DontDestroyOnLoad(instance.gameObject); 
            }
            else if(instance != value)
            {
                Destroy(value.gameObject); 
            }
        }
    }

    private void Awake()
    {
        Instance = this as T; 
    }
}
