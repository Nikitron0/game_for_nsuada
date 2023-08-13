using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cCom : MonoBehaviour
{
    public GameObject EnterButton;
    public GameObject Ob1;
    public GameObject Ob2;
    public GameObject Ob3;

    void Update()
    {
    if (Ob1.activeSelf == true 
            && Ob1.activeSelf == true 
            && Ob2.activeSelf == true 
            && Ob3.activeSelf == true)
        {
            EnterButton.SetActive(true);
        }
    else
        {
            EnterButton.SetActive(false);
        }
    }
}
