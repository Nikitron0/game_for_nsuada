using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTrigger : MonoBehaviour
{
    public GameObject EnterButton;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Guy"))
        {
            EnterButton.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Guy"))
        {
            EnterButton.SetActive(false);
        }
    }

}
