using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DD : MonoBehaviour
{
    static bool created = false;
    public bool Loading = true;

    void Awake() 
    {
        if (created) 
        { 
            Destroy(this.gameObject); 
        } 
    }
}