using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickAct : MonoBehaviour
{
    public GameObject sil;
    public GameObject Pred;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Pred.SetActive(false);
        sil.SetActive(true);
    }
}
