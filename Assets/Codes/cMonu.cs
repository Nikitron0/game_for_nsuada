using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cMonu : MonoBehaviour
{
     public GameObject EnterButton;
    public GameObject Ob1;
    public GameObject Ob2;
    public GameObject Ob3;
    public GameObject Ob4;
    public GameObject Ob5;
    public GameObject Ob6;
    public GameObject Ob7;
    public GameObject Ob8;
    public GameObject Ob9;
    public GameObject Ob10;
    public GameObject Ob11;
    public GameObject Ob12;
    public GameObject Ob13;

    void Update()
    {
    if (Ob1.activeSelf == true 
            && Ob2.activeSelf == true 
            && Ob3.activeSelf == true 
            && Ob4.activeSelf == true 
            && Ob5.activeSelf == true 
            && Ob6.activeSelf == true 
            && Ob7.activeSelf == true 
            && Ob8.activeSelf == true
            && Ob9.activeSelf == true
            && Ob10.activeSelf == true
            && Ob11.activeSelf == true
            && Ob12.activeSelf == true
            && Ob13.activeSelf == true)
        {
            EnterButton.SetActive(true);
        }
    else
        {
            EnterButton.SetActive(false);
        }
    }
}
