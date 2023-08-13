using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class c118 : MonoBehaviour
{
     public GameObject EnterButton;
     public GameObject Ob1;
     public GameObject Ob2;
     public GameObject Ob3;
     public GameObject Ob4;
     public GameObject Ob5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    if (Ob1.activeSelf == true && Ob2.activeSelf == true && Ob3.activeSelf == true && Ob4.activeSelf == true && Ob5.activeSelf == true)
    {
        EnterButton.SetActive(true);
    }
    }
}
