using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cDcost : MonoBehaviour
{
    public GameObject EnterButton;
    public GameObject Ob1;
    public GameObject Ob2;

    void Update()
    {
    if (Ob1.activeSelf == true && Ob2.activeSelf == true)
        {
            EnterButton.SetActive(true);
        }
    else
        {
            EnterButton.SetActive(false);
        }
    }
}
