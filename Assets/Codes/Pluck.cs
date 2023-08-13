using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pluck : MonoBehaviour
{
    public GameObject PluckPiece;
    public string TagN;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == TagN)
        {
            PluckPiece.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == TagN)
        {
            PluckPiece.SetActive(false);
        }
    }

}