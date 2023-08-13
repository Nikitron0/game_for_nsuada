using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cMuse : MonoBehaviour
{
     public GameObject EnterButton;
     public GameObject Ob1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    if (Ob1.activeSelf == true)
        {
            EnterButton.SetActive(true);
        }
    else
        {
            EnterButton.SetActive(false);
        }
    }
}
