using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyOnLoadScene : MonoBehaviour
{
    public GameObject[] objects;

    // Start is called before the first frame update


    void Awake()
    {
        foreach(var elements in objects)
        {
            DontDestroyOnLoad(elements);
        }
    }

    
}
