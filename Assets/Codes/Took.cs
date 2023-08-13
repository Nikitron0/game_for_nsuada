using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Took : MonoBehaviour
{
    public GameObject TookPiece;
    public GameObject MovePiece;
    public string TagN;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == TagN)
        {
            TookPiece.SetActive(true);
            MovePiece.SetActive(false);
        }
    }
}