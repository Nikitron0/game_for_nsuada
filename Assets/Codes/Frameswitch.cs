using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frameswitch : MonoBehaviour
{

    public GameObject activeFrame;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Guy"))
        {
            activeFrame.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Guy"))
        {
            activeFrame.SetActive(false);
        }
    }

}
