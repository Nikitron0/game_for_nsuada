using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DDT : MonoBehaviour
{
    static bool CR = false;
    public bool Loading = true;
    public GameObject EB;
    static bool created = false;

    void Awake()
    {
        if (CR && EB.activeSelf == true)
        {
            created = true;
        }
        CR = true;
    }
}