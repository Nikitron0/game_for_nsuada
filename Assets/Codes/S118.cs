using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class S118 : MonoBehaviour
{
    [SerializeField] int clks;
    public GameObject nobe1;
    public GameObject nobe2;
    public GameObject nobeE;

    public void ButtonClick()
    {
        clks++;
    }

    // Update is called once per frame
    void Update()
    {
        if (clks == 31)
        {
            nobe1.SetActive(false);
            nobe2.SetActive(false);
            nobeE.SetActive(true);
        }
    }
}
